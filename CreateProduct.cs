using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public CreateProduct()
        {
            InitializeComponent();
            this.QuantityTxt.Text = "0";
            this.PriceTxt.Text = "0.00";
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
                this.titlePanel.Text = "Edit Product";
                db = new DbConnectorClass();
                SqlDataReader dbReader = db.RunQuery("select * from dbo.product where product_id = " + id);
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
                        sqlQuery = "INSERT INTO dbo.product " +
                        "(product, price, quantity, note) VALUES " +
                        "('" + this.ProductTxt.Text + "', " +
                        " '" + this.PriceTxt.Text + "', " +
                        " '" + this.QuantityTxt.Text + "', " +
                        " '" + this.NoteTxt.Text + "') ";
                    }
                    else
                    {
                        sqlQuery = "UPDATE dbo.product set " +
                        "product = '" + this.ProductTxt.Text + "', " +
                        "price = '" + this.PriceTxt.Text + "', " +
                        "quantity = '" + this.QuantityTxt.Text + "', " +
                        "note = '" + this.NoteTxt.Text + "' WHERE product_id = " + this.dbNo;
                    }
                    db.RunQuery(sqlQuery).Close();
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
                    String sqlQuery = "DELETE FROM dbo.product WHERE product_id= "+ this.dbNo;
                    db.RunQuery(sqlQuery).Close();
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
