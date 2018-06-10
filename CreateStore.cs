using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace Invoice
{
    public partial class CreateStore : ResizeForm
    {
        private DbConnectorClass db;
        private Boolean isEdit = false;
        private String dbId;
        private String dbStoreName;
        private String dbStoreAddress;
        private String dbStorePhone;
        private String dbStoreFax;
        private String dbContactName;
        private String dbContactPhone;
        private String dbStoreDetail;
        private StoreList sl;
        private Boolean isSave = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public CreateStore()
        {
            InitializeComponent();
        }
        public CreateStore(String id, StoreList sl)
        {
            InitializeComponent();
            Init_deleteBtn();
            Store_Load(id);
            this.sl = sl;
        }
        private void Store_Load(String id)
        {
            try
            {
                isEdit = true;
                this.titlePanel.Text = "Edit Product";
                db = new DbConnectorClass();
                SqlDataReader dbReader = db.RunQuery("select * from dbo.store where store_id = " + id);
                if (dbReader.Read())
                {
                    this.dbId = id;
                    this.storeNameTxt.Text = db.NullToNA(dbReader, "store_name");
                    this.storePhoneTxt.Text = db.NullToNA(dbReader, "store_phone");
                    this.storeAddressTxt.Text = db.NullToNA(dbReader, "store_address");
                    this.storeFaxTxt.Text = db.NullToNA(dbReader, "store_fax");
                    this.contactNameTxt.Text = db.NullToNA(dbReader, "contact_name");
                    this.contactPhoneTxt.Text = db.NullToNA(dbReader, "contact_phone");
                    this.storeDetailTxt.Text = db.NullToNA(dbReader, "store_detail");
                    Object isMarketValue = db.NullToNA(dbReader, "isMarket");
                    this.isMarket.Checked = (isMarketValue.Equals("1")) ? true : false;
                }
                SyncData();
                dbReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SyncData()
        {
            this.dbStoreName = this.storeNameTxt.Text;
            this.dbStorePhone = this.storePhoneTxt.Text;
            this.dbStoreAddress = this.storeAddressTxt.Text;
            this.dbStoreFax = this.storeFaxTxt.Text;
            this.dbContactName = this.contactNameTxt.Text;
            this.dbContactPhone = this.contactPhoneTxt.Text;
            this.dbStoreDetail = this.storeDetailTxt.Text;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var x = MessageBox.Show("Are you sure you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    String sqlQuery = "";
                    if (this.dbId ==null)
                    {
                        sqlQuery = "INSERT INTO dbo.store " +
                        "(store_name, store_phone, store_address, store_fax, store_detail, contact_phone, contact_name, isMarket) VALUES " +
                        "(N'" + this.storeNameTxt.Text + "', " +
                        " '" + this.storePhoneTxt.Text + "', " +
                        " N'" + this.storeAddressTxt.Text + "', " +
                        " '" + this.storeFaxTxt.Text + "', " +
                        " N'" + this.storeDetailTxt.Text + "', " +
                        " '" + this.contactPhoneTxt.Text + "', " +
                        " N'" + this.contactNameTxt.Text + "', " +
                        " '" + ((this.isMarket.Checked) ? 1: 0) + "') ";
                    }
                    else
                    {
                        sqlQuery = "UPDATE dbo.store set " +
                        "store_name = N'" + this.storeNameTxt.Text + "', " +
                        "store_phone = '" + this.storePhoneTxt.Text + "', " +
                        "store_address = N'" + this.storeAddressTxt.Text + "', " +
                        "store_fax = '" + this.storeFaxTxt.Text + "', " +
                        "store_detail = N'" + this.storeDetailTxt.Text + "', " +
                        "contact_phone = '" + this.contactPhoneTxt.Text + "', " +
                        "contact_name = N'" + this.contactNameTxt.Text + "', " +
                        "isMarket = '" + ((this.isMarket.Checked) ? 1: 0) + "' WHERE store_id= " + this.dbId;
                    }
                    db.RunQuery(sqlQuery).Close();
                    // need to close createStore form after click 'OK' button
                }
                isSave = true;
                if (this.sl != null)
                    this.sl.GetStoreList();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean HasDateChange()
        {
            if (isEdit)
            {
                if (!this.storeNameTxt.Text.Equals(this.dbStoreName) ||
                !this.storePhoneTxt.Text.Equals(this.dbStorePhone) ||
                !this.storeAddressTxt.Text.Equals(this.dbStoreAddress) ||
                !this.storeFaxTxt.Text.Equals(this.dbStoreFax) ||
                !this.contactNameTxt.Text.Equals(this.dbContactName) ||
                !this.contactPhoneTxt.Text.Equals(this.dbContactPhone) ||
                !this.storeDetailTxt.Text.Equals(this.dbStoreDetail))
                {
                    return true;
                }
            }
            else
            {
                if (!this.storeNameTxt.Text.Equals("") ||
                !this.storePhoneTxt.Text.Equals("") ||
                !this.storeAddressTxt.Text.Equals("") ||
                !this.storeFaxTxt.Text.Equals("") ||
                !this.contactNameTxt.Text.Equals("") ||
                !this.contactPhoneTxt.Text.Equals("") ||
                !this.storeDetailTxt.Text.Equals(""))
                {
                    return true;
                }
            }
            return false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (HasDateChange() && !isSave)
            {
                var x = MessageBox.Show("Are you sure you want to really exit?\n unsaved data will be lost. ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    db.Close();
                    if(sl != null)
                       sl.GetStoreList();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void CreateStore_Load(object sender, EventArgs e)
        {
             db = new DbConnectorClass();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var x = MessageBox.Show("Are you sure you want to delete? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    String sqlQuery = "DELETE FROM dbo.store WHERE store_id= " + this.dbId;
                    db.RunQuery(sqlQuery).Close();
                    // need to close this form after click 'OK' button
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StorePhoneTxt_TextChanged(object sender, EventArgs e)
        {
            this.storePhoneTxt.Text = ChangeToPhoneFormat(this.storePhoneTxt.Text);
        }

        private void StoreFaxTxt_TextChanged(object sender, EventArgs e)
        {
            this.storeFaxTxt.Text = ChangeToPhoneFormat(this.storeFaxTxt.Text);
        }

        private void ContactPhoneTxt_TextChanged(object sender, EventArgs e)
        {
            this.contactPhoneTxt.Text = ChangeToPhoneFormat(this.contactPhoneTxt.Text);
        }
        private String ChangeToPhoneFormat(String value)
        {
            value = Regex.Replace(value, @"/[^\d]/g", "");
            return Regex.Replace(value, @"(\d{3})(\d{3})(\d{4})", "($1)-$2-$3");
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
    }
}
