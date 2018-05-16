using System;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Invoice
{
    public partial class CreateOrder : ResizeForm
    {
        private DbConnectorClass db;
        DataSet myDataSet = new DataSet();
        SqlDataAdapter adapter;
        String orderId;
        DataSet DS;
        private int PRODUCT = 0;
        private int QTY = 1;
        private int PRICE = 2;
        private int AMOUNT = 3;
        private int MARKET = 4;
        private int NOTE = 5;
        private int ROUTE = 6;
        private OrderList ol;
        private ArrayList qtyList = new ArrayList(); 
        private bool isSave = false;
        private SqlDataReader dbReader;
        private bool isMarket;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public CreateOrder()
        {
            InitializeComponent();
            SetComboBox();
            SetDateInWeekDay();
        }
        private void SetDateInWeekDay()
        {
            DateTime pickedDate = DateTime.Today;
            if (pickedDate.DayOfWeek.Equals(DayOfWeek.Sunday)) {
                pickedDate = pickedDate.AddDays(1);
            }
            else if(pickedDate.DayOfWeek.Equals(DayOfWeek.Saturday)){
                pickedDate = pickedDate.AddDays(2);
            }
            this.DeliveryDate.Value = pickedDate;
        }
        public CreateOrder(String id, OrderList ol)
        {
            InitializeComponent();
            SetComboBox();
            Init_deleteBtn();
            OrderLoad(id);
            this.orderId = id;
            this.ol = ol;
        }
        private void SetComboBox()
        {
            try
            {
                db = new DbConnectorClass();
                dbReader = db.RunQuery("select * from dbo.product order by product asc");
                while (dbReader.Read())
                {
                    (this.orderDataView.Columns[0] as DataGridViewComboBoxColumn)
                        .Items.Add(db.NullToEmpty(dbReader, "product"));
                }
                dbReader.Close();
                dbReader = db.RunQuery("select * from dbo.store order by store_id asc");
                while (dbReader.Read())
                {
                    ComboboxItem comboItem = new ComboboxItem
                    {
                        Text = db.NullToEmpty(dbReader, "store_name") +
                        ", (" + db.NullToEmpty(dbReader, "store_phone") +
                        "), " + db.NullToEmpty(dbReader, "store_address") +
                        " (Contact: " + db.NullToEmpty(dbReader, "contact_name") + ")",
                        Value = db.NullToEmpty(dbReader, "isMarket")
                    };
                    this.StoreList.Items.Add(comboItem);
                }
                this.StoreList.AutoCompleteMode = AutoCompleteMode.Append;
                this.StoreList.DropDownStyle = ComboBoxStyle.DropDownList;
                this.StoreList.AutoCompleteSource = AutoCompleteSource.ListItems;
                dbReader.Close();
               this.orderDataView.EditingControlShowing += 
                    new DataGridViewEditingControlShowingEventHandler(DataGridView_EditingControlShowing);
                this.orderDataView.CellValueChanged += 
                    new DataGridViewCellEventHandler(DataGridView1_CellValueChanged);
                this.orderDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OrderLoad(String id)
        {
            try
            {
                db = new DbConnectorClass();
                adapter = new SqlDataAdapter("SELECT Product, quantity AS QTY, " +
                    "Price, (price * quantity) AS Amount, Market, Note, Route " +
                    "FROM dbo.cart where quantity > 0 and order_id = "+id, db.GetConnection());
                // Create one DataTable with one column.
                this.DS = new DataSet();
                adapter.Fill(DS);
                this.orderDataView.Rows.Clear();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    DataRow myRow = DS.Tables[0].Rows[i];
                    DataGridViewRow row = (DataGridViewRow)this.orderDataView.Rows[0].Clone();
                    row.Cells[PRODUCT].Value = myRow[PRODUCT];
                    row.Cells[QTY].Value = myRow[QTY];
                    row.Cells[PRICE].Value = myRow[PRICE];
                    row.Cells[AMOUNT].Value = myRow[AMOUNT];
                    row.Cells[MARKET].Value = myRow[MARKET];
                    row.Cells[NOTE].Value = myRow[NOTE];
                    row.Cells[ROUTE].Value = myRow[ROUTE];
                    this.orderDataView.Rows.Add(row);
                    qtyList.Add(myRow[QTY]);
                }
                dbReader = db.RunQuery("select * from dbo.store as s inner join dbo.order_list as o " +
                    "on s.store_id = o.store_id where order_id = "+id+";");
                if(dbReader.Read())
                {
                    this.StoreList.SelectedIndex = this.StoreList.FindString(
                        db.NullToEmpty(dbReader, "store_name") +
                        ", (" + db.NullToEmpty(dbReader, "store_phone") +
                        "), " + db.NullToEmpty(dbReader, "store_address") +
                        " (Contact: " + db.NullToEmpty(dbReader, "contact_name") + ")");
                    this.DeliveryDate.Value = Convert.ToDateTime(db.NullToEmpty(dbReader, "delivery_date"));
                    this.isMarket = db.NullToEmpty(dbReader, "isMarket").Equals('1') ? true: false;
                }
                dbReader.Close();
                //this.orderDataView.DataSource = DS.Tables[0];
                this.orderDataView.AutoGenerateColumns = true;
                this.orderDataView.AutoResizeColumns();
                UpdateBalance(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update the balance column whenever the value of any cell changes.
            UpdateBalance();
        }
        private void UpdateBalance()
        {
            int counter;
            double qty;
            double price;
            double total = 0;

            // Iterate through the rows, skipping the Starting Balance row.
            for (counter = 0; counter < (this.orderDataView.Rows.Count); counter++)
            {
                price = 0;
                qty = 0;
                DataGridViewRow dataRow = this.orderDataView.Rows[counter];
                Object qtyValue = dataRow.Cells[QTY].Value;
                Object priceValue = dataRow.Cells[PRICE].Value;
               
                if (qtyValue != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (qtyValue.ToString().Length != 0)
                    {
                        qty = Convert.ToDouble(qtyValue.ToString());
                    }
                }

                if (priceValue != null)
                {
                    if (priceValue.ToString().Length != 0)
                    {
                        priceValue = Regex.Replace(priceValue.ToString(), "[^a-zA-Z0-9_.]+", "", 
                            RegexOptions.Compiled);
                        price = Convert.ToDouble(priceValue.ToString());
                        dataRow.Cells[PRICE].Value = "$" + priceValue;
                    }
                }
                dataRow.Cells[AMOUNT].Value =  "$"+(qty * price).ToString();
                total += (qty * price);
            }
            this.TotalTxt.Text = total.ToString();
        }

        public void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
            {
            if (e.Control is ComboBox combo)
            {
                // Remove an existing event-handler, if present, to avoid 
                // adding multiple handlers when the editing control is reused.
                combo.SelectedIndexChanged -= new EventHandler(ProductSelectionChanged);
                // Add the event handler. 
                combo.SelectedIndexChanged += new EventHandler(ProductSelectionChanged);
            }
        }


        private void ProductSelectionChanged(object sender, EventArgs e)
        {
            String prodName = (String)((ComboBox)sender).SelectedItem;
            int rowIndex = (int)((DataGridViewComboBoxEditingControl)sender).EditingControlRowIndex;
            try
            {
                db = new DbConnectorClass();
                dbReader = db.RunQuery("select * from dbo.product where product ='"+prodName+"';");

                if (dbReader.Read())
                {
                    //product, qty, price, amount, market, note
                    Object[] values = { db.NullToEmpty(dbReader, "product"), 0,
                        "$" + db.NullToEmpty(dbReader, "price"), 0, "", db.NullToEmpty(dbReader, "note") };
                    orderDataView.Rows[rowIndex].SetValues(values);
                }
                dbReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
                ((ComboBox)e.Control).AutoCompleteSource = AutoCompleteSource.ListItems;
                ((ComboBox)e.Control).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }

        //use some variable to store the last edited value
        /*string editingValue;
        //EditingControlShowing event handler
        private void DataGridView1_EidtingControlShowing(object sender,
                                          DataGridViewEditingControlShowingEventArgs e)
        {
            var combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.DropDownStyle = ComboBoxStyle.DropDown;
                combo.TextChanged += (s, ev) => {
                    editingValue = combo.Text;
                };
            }
        }
        //CellEndEdit event handler for your dataGridView1
        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var comboColumn = this.orderDataView.Columns[e.ColumnIndex] as DataGridViewComboBoxColumn;
            if (comboColumn != null && editingValue != "" &&
               !comboColumn.Items.Contains(editingValue))
            {
                comboColumn.Items.Add(editingValue);
                this.orderDataView[e.ColumnIndex, e.RowIndex].Value = editingValue;
            }
        }*/
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckIfEmpty()
        {
            bool ErrorFound = false;
            String msg = "";

            //ignore last row
            for (int i=0; i< this.orderDataView.Rows.Count-1; i++)
            {
                DataGridViewRow row = this.orderDataView.Rows[i];
                
                if (!HasValue(row.Cells[PRODUCT].Value))
                {
                   msg = "You have to set product on row "+i;
                   ErrorFound = true;
                }
                else if (!HasValue(row.Cells[QTY].Value))
                {
                    msg = "You have to set quantity on row " + i ;
                    ErrorFound = true;
                }
                else if (!HasValue(row.Cells[PRICE].Value))
                {
                    msg = "You have to set price on row " + i ;
                    ErrorFound = true;
                }
                else if (Double.Parse(row.Cells[PRICE].Value.ToString().Substring(1)) < 0)
                {
                    msg = "You have to set price above or equal to 0 on row " + i ;
                    ErrorFound = true;
                }
                if (ErrorFound)
                    break;
            }
            if (this.StoreList.SelectedItem == null || this.StoreList.SelectedItem.Equals(""))
            {
                msg = "You have to choose customer information";
                ErrorFound = true;
            }
            if (ErrorFound)
            {
                MessageBox.Show(msg, "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return ErrorFound;
        }
        private bool HasValue(Object obj){
            if(obj == null || obj.ToString().Equals("")){
                return false;
            }
            else return true;
        }
        private bool IsWeekend()
        {
            DateTime pickedDate = this.DeliveryDate.Value;

            // lastMonday is always the Monday before nextSunday.
            // When date is a Sunday, lastMonday will be tomorrow. 
            if(pickedDate.DayOfWeek.Equals(DayOfWeek.Sunday) || pickedDate.DayOfWeek.Equals(DayOfWeek.Saturday))
            {
                return true;
            }
            return false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //myDataSet.AcceptChanges();EDIT:Don't know why, but this line wasn't letting the chane in db happen.
            try
            {
                if (IsWeekend())
                {
                    MessageBox.Show("You cannot make an order on Weekend ", "Choose Again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var x = MessageBox.Show("Do you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == x && !CheckIfEmpty())
                    {
                        String sqlQuery = "";
                        if (this.orderId == null)
                        {
                            sqlQuery = "INSERT INTO dbo.order_list " +
                            "(store_id, ordered_date, delivery_date, total) VALUES " +
                            "('" + (this.StoreList.SelectedIndex + 1) + "', " +
                            " getDATE(), " +
                            " '" + Convert.ToDateTime(this.DeliveryDate.Value.ToString()).ToString("yyyy-MM-dd") + "', " +
                            " '" + this.TotalTxt.Text + "') ";
                            db.RunQuery(sqlQuery).Close();
                            SqlDataReader dbReader = db.RunQuery("Select top 1 order_id from dbo.order_list order by order_id desc");
                            if (dbReader.Read())
                            {
                                //product, qty, price, amount, market, note
                                this.orderId = (String)db.NullToEmpty(dbReader, "order_id");
                            }
                            dbReader.Close();
                            for (int i = 0; i < this.orderDataView.Rows.Count - 1; i++)
                            {
                                DataGridViewRow row = this.orderDataView.Rows[i];
                                String product = row.Cells[PRODUCT].Value.ToString();
                                String qty = row.Cells[QTY].Value.ToString();
                                String price = row.Cells[PRICE].Value.ToString().Substring(1);
                                String market = row.Cells[MARKET].Value.ToString();
                                String note = row.Cells[NOTE].Value.ToString();
                                String route = "";
                                if (row.Cells[ROUTE].Value != null)
                                {
                                    route = row.Cells[ROUTE].Value.ToString();
                                }
                                string InsertSql = "INSERT INTO dbo.cart(quantity, product, price, market, note, route, order_id) VALUES(" +
                                    "'" + qty + "', '" + product + "', '" + price + "', '" +
                                    market + "', '" + note + "', '" + route + "', '" + this.orderId + "')";
                                db.RunQuery(InsertSql).Close();
                                String buyOrSell = this.isMarket ? "+" : "-";
                                string updateQuantity = "UPDATE dbo.product set quantity = (quantity " + buyOrSell + " " + qty + ") where product ='" + product + "'";
                                db.RunQuery(updateQuantity).Close();
                            }
                        }
                        else
                        {
                            sqlQuery = "UPDATE dbo.order_list set " +
                            "delivery_date = '" + Convert.ToDateTime(this.DeliveryDate.Value.ToString()).ToString("yyyy-MM-dd") + "', " +
                            "total = '" + this.TotalTxt.Text + "' WHERE order_id= " + this.orderId;
                            adapter.Update(this.DS);
                            db.RunQuery(sqlQuery).Close();
                            for (int i = 0; i < this.orderDataView.Rows.Count - 1; i++)
                            {
                                DataGridViewRow row = this.orderDataView.Rows[i];
                                String product = row.Cells[PRODUCT].Value.ToString();
                                String qty = row.Cells[QTY].Value.ToString();
                                String price = row.Cells[PRICE].Value.ToString().Substring(1);
                                String market = row.Cells[MARKET].Value.ToString();
                                String note = row.Cells[NOTE].Value.ToString();
                                String route = "";
                                if (row.Cells[ROUTE].Value != null)
                                {
                                    route = row.Cells[ROUTE].Value.ToString();
                                }
                                string whereStr = " WHERE product='" + product + "' and order_id='" + this.orderId + "'";
                                string checkExist = "SELECT * FROM dbo.cart " + whereStr;
                                dbReader = db.RunQuery(checkExist);
                                string InsertSql = "";
                                if (!dbReader.Read())
                                {
                                    InsertSql = "INSERT INTO dbo.cart(quantity, product, price, market, note, route, order_id) VALUES(" +
                                    "'" + qty + "', '" + product + "', '" + price + "', '" +
                                    market + "', '" + note + "', '" + route + "', '" + this.orderId + "')";
                                }
                                else
                                {
                                    InsertSql = "UPDATE dbo.cart set quantity='" + qty +
                                    "', price='" + price + "', market='" + market + "', note='" + note +
                                    "', route='" + route + "' " + whereStr;
                                }
                                dbReader.Close();
                                db.RunQuery(InsertSql).Close();
                                int diff = Int32.Parse(qty) - Int32.Parse(qtyList[i].ToString());
                                String buyOrSell = this.isMarket ? "-" : "+";
                                string updateQuantity = "UPDATE dbo.product set quantity = (quantity " + buyOrSell + " " + diff + ") where product ='" + product + "'";
                                db.RunQuery(updateQuantity).Close();
                            }
                        }
                        // need to close createStore form after click 'OK' button
                        isSave = true;
                        if (this.ol != null)
                            this.ol.OrderLoad();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!isSave)
            {
                var x = MessageBox.Show("Do you want to exit?\n unsaved data will be lost. ",
                    "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    db.Close();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var x = MessageBox.Show("Do you want to delete? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    String sqlQuery = "DELETE FROM dbo.cart WHERE order_id= " + this.orderId;
                    db.RunQuery(sqlQuery);
                    sqlQuery = "DELETE FROM dbo.order_list WHERE order_id= " + this.orderId;
                    db.RunQuery(sqlQuery).Close();
                    MessageBox.Show("Data Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.None);
                    // need to close this form after click 'OK' button
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String routeIdx = ""+(this.RouteComboBox.SelectedIndex + 1);
            for (int i = 0; i < this.orderDataView.Rows.Count - 1; i++)
            {
                DataGridViewRow row = this.orderDataView.Rows[i];
                if(row.Cells[ROUTE].Value == null)
                    row.Cells[ROUTE].Value = routeIdx;
            }
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            //String isMarket = ((sender as ComboBox).SelectedItem as ComboboxItem).Value.ToString();
            //(comboBox1.SelectedItem as ComboboxItem).Value.ToString()
            this.isMarket = isMarket.Equals("1") ? true : false;
            if (this.isMarket)
            {
                this.BillToLbl.Text = "Buy From (Market): ";
            }
            else
            {
                this.BillToLbl.Text = "Bill To (Customer): ";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DragTitlePanel(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        Bitmap bmp;
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        public DataGridView getOrderDataView()
        {
            return this.orderDataView;
        }
        public void setOrderDataView(DataGridView orderDataView)
        {
            this.orderDataView = orderDataView;
        }

        private void ProdListBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection rows = this.orderDataView.Rows;
            ArrayList products = new ArrayList();
            for (int i = 0; i < rows.Count; i++ )
            {
                products.Add(rows[i].Cells[0].Value);
            }
            ProductCollection pc = new ProductCollection(this, products);
            pc.Show();
        }

    }
}
