using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public CreateOrder()
        {
            InitializeComponent();
            SetComboBox();
        }
        public CreateOrder(String id)
        {
            InitializeComponent();
            Init_deleteBtn();
            OrderLoad(id);
            this.orderId = id;
        }

        private void SetComboBox()
        {
            try
            {
                db = new DbConnectorClass();
                MySqlDataReader dbReader = db.RunQuery("select * from invoice_db.product order by product asc");
                DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn
                {
                    HeaderText = "Product",
                    FlatStyle = FlatStyle.Standard,
                    ReadOnly = false,
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                    AutoComplete = true
                };

                while (dbReader.Read())
                {
                    combo.Items.Add(db.NullToEmpty(dbReader, "product"));
                }
                db = new DbConnectorClass();
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
                this.orderDataView.Columns.Insert(PRODUCT, combo);
                this.orderDataView.Columns[NOTE].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.orderDataView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DataGridView1_EditingControlShowing);
                this.orderDataView.CellValueChanged += new DataGridViewCellEventHandler(DataGridView1_CellValueChanged);
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
                adapter = new MySqlDataAdapter("SELECT quantity AS QTY, product AS Product," +
                    "price AS Price, Amount AS (price * quantity), market AS Market, note AS Note" +
                    "FROM invoice_db.cart where order_id = "+id, db.GetConnection());
                // Create one DataTable with one column.
                this.DS = new DataSet();
                adapter.Fill(DS);
                this.orderDataView.DataSource = DS.Tables[0];
                this.orderDataView.AutoGenerateColumns = true;
                this.orderDataView.AutoResizeColumns();
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
                        price = Convert.ToDouble(priceValue.ToString().Substring(1));
                    }
                }
                dataRow.Cells[AMOUNT].Value =  (qty * price).ToString();
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
                MySqlDataReader dbReader = db.RunQuery("select * from invoice_db.product where product ='"+prodName+"';");

                if (dbReader.Read())
                {
                    //product, qty, price, amount, market, note
                    Object[] values = { db.NullToEmpty(dbReader, "product"), 0, "$" + db.NullToEmpty(dbReader, "price"), 0, "", db.NullToEmpty(dbReader, "note") };
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
                ((ComboBox)e.Control).AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //myDataSet.AcceptChanges();EDIT:Don't know why, but this line wasn't letting the chane in db happen.
            try
            {
                var x = MessageBox.Show("Are you sure you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    String sqlQuery = "";
                    if (this.orderId == null)
                    {
                        sqlQuery = "INSERT INTO invoice_db.order " +
                        "(store_id, ordered_date, delievery_date, total) VALUES " +
                        "('" + this.StoreList.SelectedIndex+1 + "', " +
                        " CURDATE(), " +
                        " '" + this.DeliveryDate.Value + "', " +
                        " '" + this.TotalTxt.Text + "') ";
                        for(int i=0; i < this.orderDataView.Rows.Count; i++)
                        {
                            DataGridViewRow row = this.orderDataView.Rows[i];
                            String product = row.Cells[PRODUCT].Value.ToString();
                            String qty = row.Cells[QTY].Value.ToString();
                            String price = row.Cells[PRICE].Value.ToString();
                            String market = row.Cells[MARKET].Value.ToString();
                            String note = row.Cells[NOTE].Value.ToString();
                            string InsertSql = "INSERT INTO cart(quantity, product, price, market, note, order_id) VALUES(" +
                                "'" + qty + "', '" + product + "', '" + price + "', '" + market + "', '" + note + "', '" + this.orderId + "')";
                            db.RunQuery(InsertSql);
                        }
                    }
                    else
                    {
                        sqlQuery = "UPDATE invoice_db.order set " +
                        "delievery_date = '" + this.DeliveryDate.Value + "', " +
                        "total = '" + this.TotalTxt.Text + "' WHERE store_id= " + this.orderId;
                        adapter.Update(this.DS);
                    }
                    db.RunQuery(sqlQuery).Close();
                    MessageBox.Show("Data Saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.None);
                    // need to close createStore form after click 'OK' button
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var x = MessageBox.Show("Are you sure you want to really exit?\n unsaved data will be lost. ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }
}
