using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace Invoice
{
    public partial class StoreList : ResizeForm
    {
        DbConnectorClass db;
        SqlDataAdapter adapter;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public StoreList()
        {
            InitializeComponent();
            GetStoreList();
            AddBtns();
        }
        public void GetStoreList()
        {
            this.ShowMarketCheckBox.Checked = true;
            this.ShowCustomerCheckBox.Checked = true;
            GetStoreList(true, true);
        }
        public void GetStoreList(bool isMarket, bool isCustomer)
        {
            try
            {
                String whereStr = "";
                if (isMarket && isCustomer)
                {
                    whereStr = "";
                }
                else if (isMarket)
                {
                    whereStr = "where isMarket = 1";
                }
                else if (isCustomer)
                {
                    whereStr = "where isMarket = 0";
                }
                else
                {
                    whereStr = "where isMarket = 2";
                }
                db = new DbConnectorClass();
                adapter = new SqlDataAdapter("SELECT store_id AS 'Store Id', store_name AS 'Store Name'," +
                    "store_address AS Address, store_phone AS Phone, store_fax AS Fax, " +
                    "contact_name AS 'Contact Name', contact_phone AS 'Contact #', store_detail AS 'Store Detail', " +
                    "CASE WHEN  isMarket = 1 THEN 'True' ELSE 'False' END AS 'Is Market'" +
                    "FROM dbo.store " + whereStr + " order by store_name ", db.GetConnection());
                // Create one DataTable with one column.
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                this.StoreDataView.DataSource = DS.Tables[0];
                this.StoreDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            this.StoreDataView.Columns.Add(SaveBtnColumn);
            DataGridViewButtonColumn DeleteBtnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            this.StoreDataView.Columns.Add(DeleteBtnColumn);
        }
        private void DeleteStore(DataGridViewRow row)
        {
            // Retrieve the task ID.
            String storeId = row.Cells[0].Value.ToString();
            try
            {
                var x = MessageBox.Show("Are you sure you want to delete? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    String sqlQuery = "";
                    if (storeId.Equals(""))
                    {
                        this.StoreDataView.Rows.Remove(row);
                    }
                    else
                    {
                        sqlQuery = "Delete FROM dbo.store WHERE store_id = " + storeId;
                    }
                    db.RunQuery(sqlQuery).Close();
                    // need to close this form after click 'OK' button]
                    GetStoreList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveStore(DataGridViewRow row, bool saveAll)
        {
            // Retrieve the task ID.
            String storeId = "";
            String storeName = "";
            String storePhone = "";
            String storeFax = "";
            String storeAddr = "";
            String contactName = "";
            String contactPhone = "";
            String Note = "";
            string isMarket = "";
            if (row.Cells[0].Value != null)
                storeId         = row.Cells[0].Value.ToString();
            if (row.Cells[1].Value != null)
                storeName       = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value != null)
                storePhone      = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value != null)
                storeFax        = row.Cells[3].Value.ToString();
            if (row.Cells[4].Value != null)
                storeAddr       = row.Cells[4].Value.ToString();
            if (row.Cells[5].Value != null)
                contactName     = row.Cells[5].Value.ToString();
            if (row.Cells[6].Value != null)
                contactPhone    = row.Cells[6].Value.ToString();
            if (row.Cells[7].Value != null)
                Note            = row.Cells[7].Value.ToString();
            if (row.Cells[8].Value != null)
                isMarket        = row.Cells[8].Value.ToString();

            if (isMarket.Equals(""))
            {
                isMarket = "0";
            }
            try
            {
                var x = DialogResult.No;
                if (!saveAll)
                    x = MessageBox.Show("Are you sure you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x || saveAll)
                {
                    String sqlQuery = "";
                    if (storeId.Equals(""))
                    {
                        sqlQuery = "INSERT INTO dbo.store " +
                        "(store_name, store_phone, store_fax, store_address, contact_name, contact_phone, store_detail, isMarket) VALUES " +
                        "('" + storeName + "', " +
                        " '" + storePhone + "', " +
                        " '" + storeFax + "', " +
                        " '" + storeAddr + "', " +
                        " '" + contactName + "', " +
                        " '" + contactPhone + "', " +
                        " '" + Note + "', " +
                        " '" + isMarket + "') ";
                    }
                    else
                    {
                        sqlQuery = "UPDATE dbo.store set " +
                        "store_name = '" + storeName + "', " +
                        "store_phone = '" + storePhone + "', " +
                        "store_fax = '" + storeFax + "', " +
                        "store_address = '" + storeAddr + "', " +
                        "contact_name = '" + contactName + "', " +
                        "contact_phone = '" + contactPhone + "', " +
                        "store_detail = '" + Note + "', " +
                        "isMarket = '" + isMarket + "' WHERE store_id = " + storeId;
                    }
                    db.RunQuery(sqlQuery).Close();
                    // need to close this form after click 'OK' button
                    GetStoreList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isMarket = this.ShowMarketCheckBox.Checked;
            bool isCustomer = this.ShowCustomerCheckBox.Checked;
            GetStoreList(isMarket, isCustomer);
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
            for (int i = 0; i < this.StoreDataView.RowCount - 1; i++)
            {
                DataGridViewRow row = this.StoreDataView.Rows[i];
                SaveStore(row, true);
            }
        }

        private void StoreDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            int rowNum = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.StoreDataView.Rows[rowNum];
                if (e.ColumnIndex == this.StoreDataView.Columns["Save"].Index)
                    SaveStore(row, false);
                if (e.ColumnIndex == this.StoreDataView.Columns["Delete"].Index)
                    DeleteStore(row);
            }
        }
    }
}
