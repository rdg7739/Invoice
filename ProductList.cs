using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace Invoice
{
    public partial class ProductList : ResizeForm
    {
        private DbConnectorClass db;
        private SqlDataAdapter adapter;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public ProductList()
        {
            InitializeComponent();
            db = new DbConnectorClass();
            GetProductList();
            AddBtns();
        }
        public void GetProductList() {
            try
            {
                SqlDataReader dbReader = db.RunQuery("select Catagory from dbo.Catagory group by Catagory order by CASE Catagory " +
                            "WHEN 'MEAT' THEN 1 WHEN 'FROZEN' THEN 2 WHEN 'PRODUCE' THEN 3 WHEN 'GROCERY' THEN 4  WHEN 'FRUIT' THEN 5 ELSE 6  END, Catagory");
                (this.ProductDataView.Columns[4] as DataGridViewComboBoxColumn).Items.Clear();
                while (dbReader.Read())
                {
                    (this.ProductDataView.Columns[4] as DataGridViewComboBoxColumn).Items.Add(db.NullToEmpty(dbReader, "Catagory").Trim());
                }
                dbReader.Close();

                db = new DbConnectorClass();
                adapter = new SqlDataAdapter("select product_id as No, Product, Price, Quantity, Catagory, SubCatagory, Note from dbo.product order by CASE Catagory " +
                            "WHEN 'MEAT' THEN 1 WHEN 'FROZEN' THEN 2 WHEN 'PRODUCE' THEN 3 WHEN 'GROCERY' THEN 4  WHEN 'FRUIT' THEN 5 ELSE 6  END, Catagory, SubCatagory", db.GetConnection());
                // Create one DataTable with one column.
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                this.ProductDataView.Rows.Clear();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    DataRow myRow = DS.Tables[0].Rows[i];
                    DataGridViewRow row = (DataGridViewRow)ProductDataView.Rows[0].Clone();
                    row.Cells[0].Value = myRow[0].ToString();
                    row.Cells[1].Value = myRow[1].ToString();
                    row.Cells[2].Value = myRow[2].ToString();
                    row.Cells[3].Value = myRow[3].ToString();
                    row.Cells[4].Value = myRow[4].ToString().Trim();
                    SelectedCatagory(row, myRow[4].ToString().Trim());
                    row.Cells[5].Value = myRow[5].ToString().Trim();
                    row.Cells[6].Value = myRow[6].ToString();
                    this.ProductDataView.Rows.Add(row);
                }
            //    this.ProductDataView.DataSource = DS.Tables[0];
            //    this.ProductDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddBtns()
        {
            DataGridViewButtonColumn SaveBtnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Save",
                Text = "Save",
                UseColumnTextForButtonValue = true
            };
            this.ProductDataView.Columns.Add(SaveBtnColumn);
            DataGridViewButtonColumn DeleteBtnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            this.ProductDataView.Columns.Add(DeleteBtnColumn);
            this.ProductDataView.EditingControlShowing +=
                    new DataGridViewEditingControlShowingEventHandler(DataGridView_EditingControlShowing);

        }
        // Calls the Employee.RequestStatus method.
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            int rowNum = e.RowIndex;
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.ProductDataView.Rows[rowNum];
                if (e.ColumnIndex == this.ProductDataView.Columns["Save"].Index)
                    SaveProduce(row, false);
                if (e.ColumnIndex == this.ProductDataView.Columns["Delete"].Index)
                    DeleteProduce(row);
            }
        }
        String oldValue = "";
        public void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            if (e.Control is ComboBox combo)
            {
                oldValue = (String)combo.SelectedItem;
                // Remove an existing event-handler, if present, to avoid 
                // adding multiple handlers when the editing control is reused.
                combo.SelectedIndexChanged -= new EventHandler(DataGridView1_CellValueChanged);
                // Add the event handler. 
                combo.SelectedIndexChanged += new EventHandler(DataGridView1_CellValueChanged);
            }
        }
        private void DataGridView1_DataError(object sender, EventArgs e)
        {
            //do nothing when data error occur
        }
        private void DataGridView1_CellValueChanged(object sender, EventArgs e)
        {
            String catagoryName = (String)((ComboBox)sender).SelectedItem;
            int rowNum = (int)((DataGridViewComboBoxEditingControl)sender).EditingControlRowIndex;

            if (rowNum > 0)
            {
                DataGridViewRow row = this.ProductDataView.Rows[rowNum];
                if (oldValue != catagoryName)
                    SelectedCatagory(row, catagoryName);
            }
        }
        private void SelectedCatagory(DataGridViewRow row, string catagoryName)
        {
            row.Cells[5].Value = 0;
            (row.Cells[5] as DataGridViewComboBoxCell).Items.Clear();
            if (!row.Cells[4].Value.Equals("")) {
                SqlDataReader dbReader = db.RunQuery("select SubCatagory from dbo.Catagory where Catagory = '" + catagoryName.Trim() + 
                    "' group by SubCatagory order by CASE SubCatagory WHEN '' THEN 2 ELSE 1  END, SubCatagory");
                while (dbReader.Read())
                {
                    (row.Cells[5] as DataGridViewComboBoxCell).Items.Add(db.NullToEmpty(dbReader, "SubCatagory").Trim());
                }
                dbReader.Close();
            }
        }
        private void DeleteProduce(DataGridViewRow row)
        {
            // Retrieve the task ID.
            String productId = row.Cells[0].Value.ToString();
            try
            {
                var x = MessageBox.Show("Are you sure you want to delete? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    String sqlQuery = "";
                    if (productId.Equals(""))
                    {
                        this.ProductDataView.Rows.Remove(row);
                    }
                    else
                    {
                        sqlQuery = "Delete FROM dbo.product WHERE product_id = " + productId;
                    }
                    db.RunQuery(sqlQuery).Close();
                    // need to close this form after click 'OK' button]
                    GetProductList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveProduce(DataGridViewRow row, bool saveAll)
        {
            // Retrieve the task ID.
            String productId = "";
            String Product = "";
            String Price = "";
            String Quantity = "";
            String Catagory = "";
            String SubCatagory = "";
            String Note = "";
            if (row.Cells[0].Value != null)
                productId    = row.Cells[0].Value.ToString();
            if (row.Cells[1].Value != null)
                Product      = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value != null)
                Price        = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value != null)
                Quantity     = row.Cells[3].Value.ToString();
            if (row.Cells[4].Value != null)
                Catagory     = row.Cells[4].Value.ToString().ToUpper();
            if (row.Cells[5].Value != null)
                SubCatagory  = row.Cells[5].Value.ToString().ToUpper();
            if (row.Cells[6].Value != null)
                Note         = row.Cells[6].Value.ToString();

            if (Price.Equals(""))
            {
                Price = "0.00";
            }
            if (Quantity.Equals(""))
            {
                Quantity = "0";
            }
            try
            {
                var x = DialogResult.No;
                if (!saveAll)
                    x = MessageBox.Show("Are you sure you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x || saveAll)
                {
                    String sqlQuery = "";
                    if (productId.Equals(""))
                    {
                        sqlQuery = "INSERT INTO dbo.product " +
                        "(product, price, quantity, note, catagory, subcatagory) VALUES " +
                        "('" + Product + "', " +
                        " '" + Price + "', " +
                        " '" + Quantity + "', " +
                        " '" + Note + "', " +
                        " '" + Catagory + "', " +
                        " '" + SubCatagory + "') ";
                    }
                    else
                    {
                        sqlQuery = "UPDATE dbo.product set " +
                        "product = '" + Product + "', " +
                        "price = '" + Price + "', " +
                        "quantity = '" + Quantity + "', " +
                        "Note = '" + Note + "', " +
                        "Catagory = '" + Catagory + "', " +
                        "SubCatagory = '" + SubCatagory + "' WHERE product_id = " + productId;
                    }
                    db.RunQuery(sqlQuery).Close();
                    // need to close this form after click 'OK' button
                    GetProductList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < this.ProductDataView.RowCount-1; i++)
            {
                DataGridViewRow row = this.ProductDataView.Rows[i];
                SaveProduce(row, true);
            }
        }
    }
}
