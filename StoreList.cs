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
        private int STORE_ID        = 0;
        private int STORE_NAME      = 1;
        private int STORE_PHONE     = 2;
        private int STORE_FAX       = 3;
        private int STORE_ADDRESS   = 4;
        private int CONTACT_NAME    = 5;
        private int CONTACT_PHONE   = 6;
        private int STORE_NOTE      = 7;
        private int IS_MARKET       = 8;
        public StoreList()
        {
            InitializeComponent();
            GetStoreList();
            AddBtns();
            this.MaximizedBounds = Screen.GetWorkingArea(this);
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
                    "store_phone AS Phone, store_fax AS Fax, store_address AS Address, " +
                    "contact_name AS 'Contact Name', contact_phone AS 'Contact #', store_detail AS 'Store Detail', " +
                    "isMarket AS 'Is Market'" +
                    "FROM dbo.store " + whereStr + " order by store_name ", db.GetConnection());
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                this.StoreDataView.Rows.Clear();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    DataRow myRow = DS.Tables[0].Rows[i];
                    DataGridViewRow row = (DataGridViewRow)StoreDataView.Rows[0].Clone();
                    row.Cells[STORE_ID].Value       = myRow[STORE_ID].ToString();
                    row.Cells[STORE_NAME].Value     = myRow[STORE_NAME].ToString().Trim();
                    row.Cells[STORE_PHONE].Value    = myRow[STORE_PHONE].ToString().Trim();
                    row.Cells[STORE_FAX].Value      = myRow[STORE_FAX].ToString().Trim();
                    row.Cells[STORE_ADDRESS].Value = myRow[STORE_ADDRESS].ToString().Trim();
                    row.Cells[CONTACT_NAME].Value   = myRow[CONTACT_NAME].ToString().Trim();
                    row.Cells[CONTACT_PHONE].Value  = myRow[CONTACT_PHONE].ToString().Trim();
                    row.Cells[STORE_NOTE].Value     = myRow[STORE_NOTE].ToString().Trim();
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[IS_MARKET];
                    String isMarketVal = myRow[IS_MARKET].ToString().Trim();
                    if (isMarketVal.Equals("1"))
                    {
                        chk.Value = chk.TrueValue;
                    }
                    else
                    {
                        chk.Value = chk.FalseValue;
                    }
                    this.StoreDataView.Rows.Add(row);
                }
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
            String isMarket = "";
            if (row.Cells[STORE_ID].Value != null) storeId              = row.Cells[STORE_ID].Value.ToString();
            if (row.Cells[STORE_NAME].Value != null) storeName          = row.Cells[STORE_NAME].Value.ToString();
            if (row.Cells[STORE_PHONE].Value != null) storePhone        = row.Cells[STORE_PHONE].Value.ToString();
            if (row.Cells[STORE_FAX].Value != null) storeFax            = row.Cells[STORE_FAX].Value.ToString();
            if (row.Cells[STORE_ADDRESS].Value != null) storeAddr       = row.Cells[STORE_ADDRESS].Value.ToString();
            if (row.Cells[CONTACT_NAME].Value != null) contactName      = row.Cells[CONTACT_NAME].Value.ToString();
            if (row.Cells[CONTACT_PHONE].Value != null) contactPhone    = row.Cells[CONTACT_PHONE].Value.ToString();
            if (row.Cells[STORE_NOTE].Value != null) Note               = row.Cells[STORE_NOTE].Value.ToString();
            if (row.Cells[IS_MARKET].Value != null) isMarket            = row.Cells[IS_MARKET].Value.ToString();
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
                        "(N'" + storeName + "', " +
                        " '" + storePhone + "', " +
                        " '" + storeFax + "', " +
                        " N'" + storeAddr + "', " +
                        " N'" + contactName + "', " +
                        " '" + contactPhone + "', " +
                        " N'" + Note + "', " +
                        " " + isMarket + ") ";
                    }
                    else
                    {
                        sqlQuery = "UPDATE dbo.store set " +
                        "store_name = N'" + storeName + "', " +
                        "store_phone = '" + storePhone + "', " +
                        "store_fax = '" + storeFax + "', " +
                        "store_address = N'" + storeAddr + "', " +
                        "contact_name = N'" + contactName + "', " +
                        "contact_phone = '" + contactPhone + "', " +
                        "store_detail = N'" + Note + "', " +
                        "isMarket = " + isMarket + " WHERE store_id = " + storeId;
                    }
                    db.RunQuery(sqlQuery).Close();
                    // need to close this form after click 'OK' button
                    if(!saveAll)
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
            var x = MessageBox.Show("Are you sure you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == x)
            {
                for (int i = 0; i < this.StoreDataView.RowCount - 1; i++)
                {
                    DataGridViewRow row = this.StoreDataView.Rows[i];
                    SaveStore(row, true);
                }
                GetStoreList();
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
