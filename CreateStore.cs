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
    public partial class CreateStore : Form
    {
        private DbConnectorClass db;
        public CreateStore()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var x = MessageBox.Show("Are you sure you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    String sqlQuery = "INSERT INTO invoice_db.store " +
                        "(store_name, store_phone, store_address, store_fax, store_detail, contact_phone, contact_name) VALUES " +
                    "('" + this.storeNameTxt.Text + "', " +
                    " '" + this.storePhoneTxt.Text + "', " +
                    " '" + this.storeAddressTxt.Text + "', " +
                    " '" + this.storeFaxTxt.Text + "', " +
                    " '" + this.storeDetailTxt.Text + "', " +
                    " '" + this.contactPhoneTxt.Text + "', " +
                    " '" + this.contactNameTxt.Text + "') ";
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void CreateStore_Load(object sender, EventArgs e)
        {
             db = new DbConnectorClass();
        }
    }
}
