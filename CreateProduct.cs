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
    public partial class CreateProduct : Form
    {
        private DbConnectorClass db;
        private String dbNo;
        private String dbProduct;
        private String dbPrice;
        private String dbQuantity;
        private String dbNote;
        private Boolean isEdit = false;
        private ProductList pl;
        private Boolean isSave = false;
        public CreateProduct()
        {
            InitializeComponent();
        }
        public CreateProduct(String id, ProductList pl)
        {
            InitializeComponent();
            Init_deleteBtn();
            Product_Load(id);
            this.pl = pl;
        }

        private void Product_Load(String id)
        {
            try
            {
                isEdit = true;
                this.CreateProductTitleTxt.Text = "Edit Product";
                db = new DbConnectorClass();
                MySqlDataReader dbReader = db.RunQuery("select * from invoice_db.product where product_id = " + id);
                if (dbReader.Read())
                {
                    this.dbNo = id;
                    this.ProductTxt.Text = db.NullToEmpty(dbReader, "product");
                    this.PriceTxt.Text = db.NullToEmpty(dbReader, "price");
                    this.QuantityTxt.Text = db.NullToEmpty(dbReader, "quantity");
                    this.NoteTxt.Text = db.NullToEmpty(dbReader, "note");
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
            this.dbProduct = this.ProductTxt.Text;
            this.dbPrice = this.PriceTxt.Text;
            this.dbQuantity = this.QuantityTxt.Text;
            this.dbNote = this.NoteTxt.Text;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var x = MessageBox.Show("Are you sure you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    String sqlQuery = "";
                    if (this.dbNo == null)
                    {
                        sqlQuery = "INSERT INTO invoice_db.product " +
                        "(product, price, quantity, note) VALUES " +
                        "('" + this.ProductTxt.Text + "', " +
                        " '" + this.PriceTxt.Text + "', " +
                        " '" + this.QuantityTxt.Text + "', " +
                        " '" + this.NoteTxt.Text + "') ";
                    }
                    else
                    {
                        sqlQuery = "UPDATE invoice_db.product set " +
                        "product = '" + this.ProductTxt.Text + "', " +
                        "price = '" + this.PriceTxt.Text + "', " +
                        "quantity = '" + this.QuantityTxt.Text + "', " +
                        "note = '" + this.NoteTxt.Text + "' WHERE product_id = " + this.dbNo;
                    }
                    db.RunQuery(sqlQuery).Close();
                    MessageBox.Show("Data Saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.None);
                    // need to close this form after click 'OK' button
                    isSave = true;
                    if (this.pl != null)
                        this.pl.GetProductList();
                    this.Close();
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
        private Boolean HasDateChange()
        {
            if (isEdit)
            {
                if (!this.ProductTxt.Text.Equals(this.dbProduct) ||
                !this.PriceTxt.Text.Equals(this.dbPrice) ||
                !this.QuantityTxt.Text.Equals(this.dbQuantity) ||
                !this.NoteTxt.Text.Equals(this.dbNote))
                {
                    return true;
                }
            }
            else
            {
                if (!this.ProductTxt.Text.Equals("") ||
                !this.PriceTxt.Text.Equals("") ||
                !this.QuantityTxt.Text.Equals("") ||
                !this.NoteTxt.Text.Equals(""))
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
                    if(pl!= null)
                        pl.GetProductList();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void CreateItem_Load(object sender, EventArgs e)
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
                    String sqlQuery = "DELETE FROM invoice_db.product WHERE product_id= "+ this.dbNo;
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

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
