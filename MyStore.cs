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
        private dbConnectorClass db;
        public MyStore()
        {
            InitializeComponent();
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var x = MessageBox.Show("Are you sure you want to save ? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DialogResult.Yes == x)
                {
                    String sqlQuery = "UPDATE invoice_db.store SET " +
                    "store_name='" + this.StoreNameTxt.Text + "', " +
                    " store_phone = '" + this.storePhoneTxt.Text + "', " +
                    " store_address = '" + this.storeAddressTxt.Text + "', " +
                    " store_fax = '" + this.storeFaxTxt.Text + "', " +
                    " store_detail = '" + this.storeDetailTxt.Text + "' " +
                    " WHERE store_id = 1;";
                    db.runQuery(sqlQuery).Close();
                    MessageBox.Show("Saved");
                    this.Close();
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
                db = new dbConnectorClass();
                MySqlDataReader dbReader =  db.runQuery("select * from invoice_db.store where store_id = 1");
                if (dbReader.Read())
                {
                    this.StoreNameTxt.Text = db.nullToEmpty(dbReader, "store_name");
                    this.storePhoneTxt.Text = db.nullToEmpty(dbReader, "store_phone");
                    this.storeAddressTxt.Text = db.nullToEmpty(dbReader, "store_address");
                    this.storeFaxTxt.Text = db.nullToEmpty(dbReader, "store_fax");
                    this.storeDetailTxt.Text = db.nullToEmpty(dbReader, "store_detail");
                }
                dbReader.Close();
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

        private void MyStore_FormClosing(object sender, FormClosingEventArgs e)
        {
            var x = MessageBox.Show("Are you sure you want to really exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                db.Close();
                e.Cancel = false;
            }
            else if (e != null)
            {
                e.Cancel = true;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}
