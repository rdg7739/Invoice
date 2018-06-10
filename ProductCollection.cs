using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Collections;

namespace Invoice
{
    public partial class ProductCollection : ResizeForm
    {
        DbConnectorClass db;
        SqlDataAdapter adapter;
        DataSet DS;
        CreateOrder co;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        ArrayList products;
        String routeValue;
        public ProductCollection(CreateOrder co, ArrayList products, String routeValue)
        {
            this.products = products;
            this.co = co;
            this.routeValue = routeValue;
            InitializeComponent();
            ProductLoad();
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }

        public void ProductLoad()
        {
            try
            {
                db = new DbConnectorClass();
                setComboBox(this.MeatListBox, "MEAT");
                setComboBox(this.FrozenListBox, "FROZEN");
                setComboBox(this.GroceryListBox, "GROCERY");
                setComboBox(this.ProduceListBox, "PRODUCE");
                adapter = new SqlDataAdapter(
                    "Select product_id, product from dbo.product where (catagory != 'MEAT' and catagory != 'FROZEN' and catagory != 'GROCERY' and catagory != 'PRODUCE')  order by product;", db.GetConnection());
                // Create one DataTable with one column.
                this.DS = new DataSet();
                adapter.Fill(DS);
                this.EtcListBox.DataSource = DS.Tables[0];
                this.EtcListBox.DisplayMember = "product";
                this.EtcListBox.ValueMember = "product_id";
                setChecked(this.MeatListBox);
                setChecked(this.FrozenListBox);
                setChecked(this.GroceryListBox);
                setChecked(this.ProduceListBox);
                setChecked(this.EtcListBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setComboBox(CheckedListBox cb, String catagory) {
            adapter = new SqlDataAdapter(
                       "Select product_id, product from dbo.product where catagory = '"+catagory+"' order by product;", db.GetConnection());
            // Create one DataTable with one column.
            this.DS = new DataSet();
            adapter.Fill(DS);
            cb.DataSource = DS.Tables[0];
            cb.DisplayMember = "product";
            cb.ValueMember = "product_id";
        }
        private void setChecked(CheckedListBox cb)
        {
            if (this.products == null) return;
            for (int k = 0; k < this.products.Count; k++)
            {
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    String cbText = ((DataRowView)cb.Items[i]).Row.ItemArray[1].ToString();
                    String product = (String)this.products[k];
                    if (cbText.Equals(product))
                    {
                        cb.SetItemChecked(i, true);
                        break;
                    }
                }

            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            CheckedListBox[] boxList = new CheckedListBox[5];
            boxList.SetValue(this.MeatListBox, 0);
            boxList.SetValue(this.FrozenListBox, 1);
            boxList.SetValue(this.GroceryListBox, 2);
            boxList.SetValue(this.ProduceListBox, 3);
            boxList.SetValue(this.EtcListBox, 4);
            DataGridView dataView = this.co.getOrderDataView();
            //use products to figure out deleted product
            for (int b = 0; b < boxList.Length; b++) {
                CheckedListBox listBox = boxList[b];
                for (int i = 0; i < listBox.CheckedItems.Count; i++)
                {
                    DataRowView item = (DataRowView)listBox.CheckedItems[i];
                    String prodName = (String)item.Row.ItemArray[1];
                    try
                    {
                        bool isFound = false;
                        for (int k = 0; k < dataView.Rows.Count; k++)
                        {
                            DataGridViewCellCollection cells = dataView.Rows[k].Cells;
                            if (cells[0].Value.Equals(prodName))
                            {
                                this.products.Remove(prodName);
                                isFound = true;
                                break;
                            }
                        }
                        if (!isFound)
                        {
                            db = new DbConnectorClass();
                            SqlDataReader dbReader = db.RunQuery("select * from dbo.product where product ='" + prodName + "';");

                            if (dbReader.Read())
                            {
                                int box = 0;
                                int each = 0;
                                int pound = 0;
                                String price = "$" + db.NullToNA(dbReader, "price");
                                int amount = 0;
                                String market = "";
                                String note = db.NullToNA(dbReader, "note");
                                //add only new items
                                dataView.Rows.Add(prodName, box, each, pound, price, amount, market, this.routeValue, note);
                            }
                            dbReader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //remove unchecked item from order list
            for (int k = 0; k < this.products.Count; k++)
            {
                for (int u = 0; u < dataView.Rows.Count; u++)
                {
                    if (dataView.Rows[u].Cells[0].Value.Equals(this.products[k]))
                    {
                        dataView.Rows.RemoveAt(u);
                        break;
                    }
                }
            }
            this.Close();
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
    }
}
