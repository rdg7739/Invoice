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
    public partial class MyStore : Form
    {
        private DbConnectorClass db;
        private String dbStoreName;
        private String dbStorePhone;
        private String dbStoreAddress;
        private String dbStoreFax;
        private String dbStoreDetail;
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
                    String sqlQuery = "UPDATE invoice_db.store SET " +
                    "store_name='" + this.storeNameTxt.Text + "', " +
                    " store_phone = '" + this.storePhoneTxt.Text + "', " +
                    " store_address = '" + this.storeAddressTxt.Text + "', " +
                    " store_fax = '" + this.storeFaxTxt.Text + "', " +
                    " store_detail = '" + this.storeDetailTxt.Text + "' " +
                    " WHERE store_id = 1;";
                    db.RunQuery(sqlQuery).Close();
                    syncData();
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
                MySqlDataReader dbReader =  db.RunQuery("select * from invoice_db.store where store_id = 1");
                if (dbReader.Read())
                {
                    this.storeNameTxt.Text = db.NullToEmpty(dbReader, "store_name");
                    this.storePhoneTxt.Text = db.NullToEmpty(dbReader, "store_phone");
                    this.storeAddressTxt.Text = db.NullToEmpty(dbReader, "store_address");
                    this.storeFaxTxt.Text =  db.NullToEmpty(dbReader, "store_fax");
                    this.storeDetailTxt.Text = db.NullToEmpty(dbReader, "store_detail");
                }
                syncData();
                dbReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void syncData()
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

    }
}
