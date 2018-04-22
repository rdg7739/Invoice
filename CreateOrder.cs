using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Invoice
{
    public partial class CreateOrder : Form
    {
        private DbConnectorClass db;
        DataSet myDataSet = new DataSet();
        MySqlDataAdapter adapter;
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
        private Boolean isSave = false;
        private MySqlDataReader dbReader;
        public CreateOrder()
        {
            InitializeComponent();
            SetComboBox();
            this.DeliveryDate.Value = DateTime.Today;
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
                dbReader = db.RunQuery("select * from invoice_db.product order by product asc");
                while (dbReader.Read())
                {
                    (this.orderDataView.Columns[0] as DataGridViewComboBoxColumn)
                        .Items.Add(db.NullToEmpty(dbReader, "product"));
                }
                dbReader.Close();
                dbReader = db.RunQuery("select * from invoice_db.store order by store_id asc");
                while (dbReader.Read())
                {
                    this.StoreList.Items.Add(
                        db.NullToEmpty(dbReader, "store_name") +
                        ", (" + db.NullToEmpty(dbReader, "store_phone") +
                        "), " + db.NullToEmpty(dbReader, "store_address") +
                        " (Contact: " + db.NullToEmpty(dbReader, "contact_name") + ")");
                }
                this.StoreList.AutoCompleteMode = AutoCompleteMode.Append;
                this.StoreList.DropDownStyle = ComboBoxStyle.DropDown;
                this.StoreList.AutoCompleteSource = AutoCompleteSource.ListItems;
                dbReader.Close();
               this.orderDataView.EditingControlShowing += 
                    new DataGridViewEditingControlShowingEventHandler(DataGridView1_EditingControlShowing);
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
                adapter = new MySqlDataAdapter("SELECT Product, quantity AS QTY, " +
                    "Price, (price * quantity) AS Amount, Market, Note, Route " +
                    "FROM invoice_db.cart where quantity > 0 and order_id = "+id, db.GetConnection());
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
                }
                dbReader = db.RunQuery("select * from invoice_db.store as s inner join invoice_db.order as o " +
                    "on s.store_id = o.store_id where order_id = "+id+";");
                if(dbReader.Read())
                {
                    this.StoreList.SelectedIndex = this.StoreList.FindString(
                        db.NullToEmpty(dbReader, "store_name") +
                        ", (" + db.NullToEmpty(dbReader, "store_phone") +
                        "), " + db.NullToEmpty(dbReader, "store_address") +
                        " (Contact: " + db.NullToEmpty(dbReader, "contact_name") + ")");
                    this.DeliveryDate.Value = Convert.ToDateTime(db.NullToEmpty(dbReader, "delivery_date"));
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

        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
                dbReader = db.RunQuery("select * from invoice_db.product where product ='"+prodName+"';");

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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //myDataSet.AcceptChanges();EDIT:Don't know why, but this line wasn't letting the chane in db happen.
            try
            {
                var x = MessageBox.Show("Are you sure you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x && !CheckIfEmpty())
                {
                    String sqlQuery = "";
                    if (this.orderId == null)
                    {
                        sqlQuery = "INSERT INTO invoice_db.order " +
                        "(store_id, ordered_date, delivery_date, total) VALUES " +
                        "('" + (this.StoreList.SelectedIndex+1) + "', " +
                        " CURDATE(), " +
                        " '" + Convert.ToDateTime(this.DeliveryDate.Value.ToString()).ToString("yyyy-MM-dd") + "', " +
                        " '" + this.TotalTxt.Text + "') ";
                        db.RunQuery(sqlQuery).Close();
                        MySqlDataReader dbReader =  db.RunQuery("Select order_id from invoice_db.order order by order_id desc limit 1");
                        if (dbReader.Read())
                        {
                            //product, qty, price, amount, market, note
                            this.orderId = db.NullToEmpty(dbReader, "order_id");
                        }
                        dbReader.Close();
                        for (int i=0; i < this.orderDataView.Rows.Count-1; i++)
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
                            string InsertSql = "INSERT INTO invoice_db.cart(quantity, product, price, market, note, route, order_id) VALUES(" +
                                "'" + qty + "', '" + product + "', '" + price + "', '" + 
                                market + "', '" + note + "', '" + route + "', '" + this.orderId + "')";
                            db.RunQuery(InsertSql).Close();
                        }
                    }
                    else
                    {
                        sqlQuery = "UPDATE invoice_db.order set " +
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
                            string checkExist = "SELECT * FROM invoice_db.cart " + whereStr;
                            dbReader = db.RunQuery(checkExist);
                            string InsertSql = "";
                            if (!dbReader.Read())
                            {
                                InsertSql = "INSERT INTO invoice_db.cart(quantity, product, price, market, note, route, order_id) VALUES(" +
                                "'" + qty + "', '" + product + "', '" + price + "', '" +
                                market + "', '" + note + "', '" + route + "', '" + this.orderId + "')";
                            }
                            else
                            {
                                InsertSql = "UPDATE invoice_db.cart set quantity='" + qty +
                                "', price='" + price + "', market='" + market + "', note='" + note +
                                "', route='" + route + "' " + whereStr;
                            }
                            dbReader.Close();
                            db.RunQuery(InsertSql).Close();
                        }
                    }
                    MessageBox.Show("Data Saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.None);
                    // need to close createStore form after click 'OK' button
                    isSave = true;
                    if(this.ol != null)
                        this.ol.OrderLoad();
                    this.Close();
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
                var x = MessageBox.Show("Are you sure you want to really exit?\n unsaved data will be lost. ",
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
                var x = MessageBox.Show("Are you sure you want to delete? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    String sqlQuery = "DELETE FROM invoice_db.cart WHERE order_id= " + this.orderId;
                    db.RunQuery(sqlQuery);
                    sqlQuery = "DELETE FROM invoice_db.order WHERE order_id= " + this.orderId;
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

        private void RouteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String routeIdx = ""+(this.RouteComboBox.SelectedIndex + 1);
            for (int i = 0; i < this.orderDataView.Rows.Count - 1; i++)
            {
                DataGridViewRow row = this.orderDataView.Rows[i];
                if(row.Cells[ROUTE].Value == null)
                    row.Cells[ROUTE].Value = routeIdx;
            }
        }

    }
}
