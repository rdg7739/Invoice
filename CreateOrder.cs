using System;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

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
        private int BOX     = 1;
        private int EACH    = 2;
        private int POUND   = 3;
        private int PRICE   = 4;
        private int AMOUNT  = 5;
        private int MARKET  = 6;
        private int ROUTE   = 7;
        private int NOTE    = 8;
        
        private OrderList ol;
        private Hashtable qtyList = new Hashtable(); 
        private bool isSave = false;
        private SqlDataReader dbReader;
        private bool isMarket;
        private bool isModified = false;
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
            this.PrintBtn.Hide();
            this.MaximizedBounds = Screen.GetWorkingArea(this);
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
            isModified = false;
            this.PrintBtn.Show();
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
                        .Items.Add(db.NullToNA(dbReader, "product"));
                }
                dbReader.Close();
                //use count to get order by popular store
                dbReader = db.RunQuery("select s.store_id, store_name, store_phone, store_address, contact_name, contact_phone, store_detail, store_fax, isMarket, count(*) as count "+
                    " from dbo.store as s full outer join dbo.order_list as o on s.store_id = o.store_id "+
                    " group by s.store_id, store_name, store_phone, store_address, contact_name, contact_phone, store_detail, store_fax, isMarket order by count(*) desc; ");
                while (dbReader.Read())
                {
                    ComboboxItem comboItem = new ComboboxItem
                    {
                        Text = db.NullToNA(dbReader, "store_id") + ": " + db.NullToNA(dbReader, "store_name") + ", (Contact: " + db.NullToNA(dbReader, "contact_name") + ")",
                        Value = db.NullToNA(dbReader, "isMarket")
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
                adapter = new SqlDataAdapter("SELECT Product, Box, Each, Pound," +
                    "Price, ((Box+Each+Pound) * price) AS Amount, Market, Route, Note " +
                    "FROM dbo.cart where (Box+Each+Pound) > 0 and order_id = " + id, db.GetConnection());
                // Create one DataTable with one column.
                this.DS = new DataSet();
                adapter.Fill(DS);
                this.orderDataView.Rows.Clear();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    DataRow myRow = DS.Tables[0].Rows[i];
                    this.orderDataView.Rows.Add(myRow[PRODUCT], myRow[BOX], myRow[EACH], myRow[POUND], myRow[PRICE], myRow[AMOUNT], myRow[MARKET], myRow[ROUTE], myRow[NOTE]);
                    double qty = getQty(myRow[BOX], myRow[EACH], myRow[POUND]);
                    qtyList.Add(myRow[PRODUCT], myRow[BOX]);
                    if (myRow[ROUTE] != null)
                    {
                        String routeVal = myRow[ROUTE].ToString();
                        this.RouteComboBox.SelectedItem = myRow[ROUTE].ToString();
                    }
                }
                dbReader = db.RunQuery("select * from dbo.store as s inner join dbo.order_list as o " +
                    "on s.store_id = o.store_id where order_id = "+id+";");
                if(dbReader.Read())
                {
                    this.StoreList.SelectedIndex = this.StoreList.FindString(
                        db.NullToNA(dbReader, "store_id") + ": " + db.NullToNA(dbReader, "store_name") + ", (Contact: " + db.NullToNA(dbReader, "contact_name") + ")");
                    this.DeliveryDate.Value = Convert.ToDateTime(db.NullToNA(dbReader, "delivery_date"));
                    this.isMarket = db.NullToNA(dbReader, "isMarket").Equals('1') ? true: false;
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
        private double getQty(object box, object each, object pound)
        {
            double qty = 0;
            try
            {
                if (Convert.ToDouble(box) > 0)
                    qty = Convert.ToDouble(box);
                else if (Convert.ToDouble(each) > 0)
                    qty = Convert.ToDouble(each);
                else if (Convert.ToDouble(pound) > 0)
                    qty = Convert.ToDouble(pound);
            }
            catch (Exception e)
            {

            }
            return qty;
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
                DataGridViewRow dataRow = this.orderDataView.Rows[counter];
                Object boxValue = dataRow.Cells[BOX].Value;
                Object eachValue = dataRow.Cells[EACH].Value;
                Object poundValue = dataRow.Cells[POUND].Value;
                Object priceValue = dataRow.Cells[PRICE].Value;
                double qtyValue = 0;
                try
                {
                    if (Convert.ToDouble(boxValue) > 0)
                    {
                        qtyValue = Convert.ToDouble(boxValue);
                        dataRow.Cells[EACH].Value = "0";
                        dataRow.Cells[POUND].Value = "0";
                    }
                    else if (Convert.ToDouble(eachValue) > 0)
                    {
                        qtyValue = Convert.ToDouble(eachValue);
                        dataRow.Cells[BOX].Value = "0";
                        dataRow.Cells[POUND].Value = "0";
                    }
                    else if (Convert.ToDouble(poundValue) > 0)
                    {
                        qtyValue = Convert.ToDouble(poundValue);
                        dataRow.Cells[BOX].Value = "0";
                        dataRow.Cells[EACH].Value = "0";
                    }
                }catch(Exception e)
                {

                }
                qty = Convert.ToDouble(qtyValue.ToString());

                if (priceValue != null)
                {
                    if (priceValue.ToString().Length != 0)
                    {
                        priceValue = Regex.Replace(priceValue.ToString(), "[^0-9.]+", "", 
                            RegexOptions.Compiled);
                        if (priceValue.Equals(""))
                        {
                            priceValue = "0";
                        }
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
                    Object[] values = { db.NullToNA(dbReader, "product"), 0,
                        "$" + db.NullToNA(dbReader, "price"), 0, "", db.NullToNA(dbReader, "note") };
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
        
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckIfEmpty()
        {
            bool ErrorFound = false;
            String msg = "";

            //ignore last row
            for (int i=0; i< this.orderDataView.Rows.Count; i++)
            {
                DataGridViewRow row = this.orderDataView.Rows[i];
                
                if (!HasValue(row.Cells[PRODUCT].Value))
                {
                   msg = "You have to set product on row "+(i+1);
                   ErrorFound = true;
                }
                else if (getQty(row.Cells[BOX].Value, row.Cells[EACH].Value, row.Cells[POUND].Value) < 1)
                {
                    msg = "You have to set quantity on row " + (i + 1);
                    ErrorFound = true;
                }
                else if (!HasValue(row.Cells[PRICE].Value))
                {
                    msg = "You have to set price on row " + (i + 1);
                    ErrorFound = true;
                }
                else if (Double.Parse(row.Cells[PRICE].Value.ToString().Substring(1)) < 0)
                {
                    msg = "You have to set price above or equal to 0 on row " + (i + 1);
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
            saveData(true);
        }
        private void saveData(bool saveFromBtn)
        {
            try
            {
                if (IsWeekend())
                {
                    MessageBox.Show("You cannot make an order on Weekend ", "Choose Again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var x = DialogResult.None;
                    if (saveFromBtn)
                    {
                        x = MessageBox.Show("Do you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else
                    {
                        x = DialogResult.Yes;
                    }
                    if (DialogResult.Yes == x && !CheckIfEmpty())
                    {
                        String sqlQuery = "";
                        String routeIdx = "" + (this.RouteComboBox.SelectedIndex + 1);
                        if (this.orderId == null)
                        {
                            sqlQuery = "INSERT INTO dbo.order_list " +
                            "(store_id, ordered_date, delivery_date, total) VALUES " +
                            "('" + (this.StoreList.Text.Split(':')[0]) + "', " +
                            " getDATE(), " +
                            " '" + Convert.ToDateTime(this.DeliveryDate.Value.ToString()).ToString("yyyy-MM-dd") + "', " +
                            " '" + this.TotalTxt.Text + "') ";
                            db.RunQuery(sqlQuery).Close();
                            SqlDataReader dbReader = db.RunQuery("Select top 1 order_id from dbo.order_list order by order_id desc");
                            if (dbReader.Read())
                            {
                                //product, qty, price, amount, market, note
                                this.orderId = (String)db.NullToNA(dbReader, "order_id");
                            }
                            dbReader.Close();
                            for (int i = 0; i < this.orderDataView.Rows.Count - 1; i++)
                            {
                                DataGridViewRow row = this.orderDataView.Rows[i];
                                String product = row.Cells[PRODUCT].Value.ToString();
                                String box = row.Cells[BOX].Value.ToString();
                                String each = row.Cells[EACH].Value.ToString();
                                String pound = row.Cells[POUND].Value.ToString();
                                String price = row.Cells[PRICE].Value.ToString().Substring(1);
                                String market = row.Cells[MARKET].Value.ToString();
                                String note = row.Cells[NOTE].Value.ToString();
                                String route = "";
                                
                                if (row.Cells[ROUTE].Value != null)
                                {
                                    route = row.Cells[ROUTE].Value.ToString();
                                }else if(!routeIdx.Equals("0"))
                                {
                                    route = routeIdx;
                                }
                                string InsertSql = "INSERT INTO dbo.cart(box, each, pound, product, price, market, note, route, order_id) VALUES(" +
                                    "'" + box + "', '" + each + "', '" + pound + "', N'" + product + "', '" + price + "', N'" +
                                    market + "', N'" + note + "', '" + route + "', '" + this.orderId + "')";
                                db.RunQuery(InsertSql).Close();
                                String buyOrSell = this.isMarket ? "+" : "-";
                                string updateQuantity = "UPDATE dbo.product set quantity = (quantity " + buyOrSell + " " + box + ") where product ='" + product + "'";
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
                            for (int i = 0; i < this.orderDataView.Rows.Count; i++)
                            {
                                DataGridViewRow row = this.orderDataView.Rows[i];
                                String product = row.Cells[PRODUCT].Value.ToString();
                                String box = row.Cells[BOX].Value.ToString();
                                String each = row.Cells[EACH].Value.ToString();
                                String pound = row.Cells[POUND].Value.ToString();
                                String price = row.Cells[PRICE].Value.ToString().Substring(1);
                                String market = row.Cells[MARKET].Value.ToString();
                                String note = row.Cells[NOTE].Value.ToString();
                                String route = "";
                                if (row.Cells[ROUTE].Value != null)
                                {
                                    route = row.Cells[ROUTE].Value.ToString();
                                }
                                else if (!routeIdx.Equals("0"))
                                {
                                    route = routeIdx;
                                }
                                string whereStr = " WHERE product='" + product + "' and order_id='" + this.orderId + "'";
                                string checkExist = "SELECT * FROM dbo.cart " + whereStr;
                                dbReader = db.RunQuery(checkExist);
                                string InsertSql = "";
                                if (!dbReader.Read())
                                {
                                    InsertSql = "INSERT INTO dbo.cart(box, each, pound, product, price, market, note, route, order_id) VALUES(" +
                                    "'" + box + "','" + each + "','" + pound + "', N'" + product + "', '" + price + "', N'" +
                                    market + "', N'" + note + "', '" + route + "', '" + this.orderId + "')";

                                }
                                else
                                {
                                    InsertSql = "UPDATE dbo.cart set box='" + box +
                                    "', price='" + price + "', market=N'" + market + "', note=N'" + note +
                                    "', route='" + route + "' " + whereStr;
                                }
                                dbReader.Close();
                                db.RunQuery(InsertSql).Close();

                                String updateQuantity = "";
                                String buyOrSell = this.isMarket ? "-" : "+";
                                int diff = Int32.Parse(box);
                                if (qtyList.ContainsKey(product))
                                {
                                    diff = Int32.Parse(box) - Int32.Parse(qtyList[product].ToString());
                                }
                                if (diff != 0)
                                {
                                    updateQuantity = "UPDATE dbo.product set quantity = (quantity " + buyOrSell + " " + diff + ") where product ='" + product + "'";
                                    db.RunQuery(updateQuantity).Close();
                                }

                            }
                        }
                        // need to close createStore form after click 'OK' button
                        isSave = true;
                        if (saveFromBtn)
                        {
                            if (this.ol != null)
                                this.ol.OrderLoad(true,true);
                            this.Close();
                        }
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
            if (!isModified)
            {
                db.Close();
                e.Cancel = false;
            }
            else if (!isSave)
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
                    db.RunQuery(sqlQuery).Close();
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
            for (int i = 0; i < this.orderDataView.Rows.Count; i++)
            {
                DataGridViewRow row = this.orderDataView.Rows[i];
                if(row.Cells[ROUTE].Value.Equals(""))
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
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            var x = DialogResult.No;
            if (isModified)
            {
                x = MessageBox.Show("Unsaved data will not show on invoice, Do you want to SAVE order?", "Open Invoice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
            if (DialogResult.Cancel == x)
            {
                return;
            }
            else if(DialogResult.Yes == x) {
                saveData(false);
            }
            printPreview preview = new printPreview(this.orderId, this.TotalTxt.Text);
            preview.Show();
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
            String routeValue = "";
            if(this.RouteComboBox.SelectedItem != null)
            {
                routeValue = this.RouteComboBox.SelectedItem.ToString();
            }
            ProductCollection pc = new ProductCollection(this, products, routeValue);
            pc.WindowState = FormWindowState.Maximized;
            pc.Show();
        }

        private void OrderListView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                isModified = true;
        }
    }
}
