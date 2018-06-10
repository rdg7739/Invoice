using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace Invoice
{
    public partial class MyStore : ResizeForm
    {
        private DbConnectorClass db;
        private String dbStoreName;
        private String dbStorePhone;
        private String dbStoreAddress;
        private String dbStoreFax;
        private String dbStoreDetail;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public MyStore()
        {
            InitializeComponent();
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var x = MessageBox.Show("Are you sure you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DialogResult.Yes == x)
                {
                    String sqlQuery = "UPDATE dbo.store SET " +
                    "store_name=N'" + this.storeNameTxt.Text + "', " +
                    " store_phone = '" + this.storePhoneTxt.Text + "', " +
                    " store_address = N'" + this.storeAddressTxt.Text + "', " +
                    " store_fax = '" + this.storeFaxTxt.Text + "', " +
                    " store_detail = N'" + this.storeDetailTxt.Text + "' " +
                    " WHERE store_id = 1;";
                    db.RunQuery(sqlQuery).Close();
                    SyncData();
                    MessageBox.Show("Data Saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyStore_Load(object sender, EventArgs e)
        {
            try
            {
                db = new DbConnectorClass();
                SqlDataReader dbReader =  db.RunQuery("select * from dbo.store where store_id = 1");
                if (dbReader.Read())
                {
                    this.storeNameTxt.Text = db.NullToNA(dbReader, "store_name");
                    this.storePhoneTxt.Text = db.NullToNA(dbReader, "store_phone");
                    this.storeAddressTxt.Text = db.NullToNA(dbReader, "store_address");
                    this.storeFaxTxt.Text =  db.NullToNA(dbReader, "store_fax");
                    this.storeDetailTxt.Text = db.NullToNA(dbReader, "store_detail");
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
            this.dbStoreDetail = this.storeDetailTxt.Text;
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!this.storeNameTxt.Text.Equals(this.dbStoreName) ||
            !this.storePhoneTxt.Text.Equals(this.dbStorePhone) ||
            !this.storeAddressTxt.Text.Equals(this.dbStoreAddress) ||
            !this.storeFaxTxt.Text.Equals(this.dbStoreFax) ||
            !this.storeDetailTxt.Text.Equals(this.dbStoreDetail)){
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
        }
        private void DragTitlePanel(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
