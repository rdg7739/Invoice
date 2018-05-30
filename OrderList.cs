using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace Invoice
{
    public partial class OrderList : ResizeForm
    {
        DbConnectorClass db;
        SqlDataAdapter adapter;
        DataSet DS;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        DateTime OrderSearchDate;
        String store_id = "";
        public OrderList()
        {
            InitializeComponent();
            OrderLoad();
            AddEditBtn();
            SqlDataReader dbReader = db.RunQuery("select s.store_id, store_name, store_phone, store_address, contact_name, contact_phone, store_detail, store_fax, isMarket, count(*) as count " +
                    " from dbo.store as s full outer join dbo.order_list as o on s.store_id = o.store_id " +
                    " group by s.store_id, store_name, store_phone, store_address, contact_name, contact_phone, store_detail, store_fax, isMarket order by count(*) desc; ");
            ComboboxItem defaultComboItem = new ComboboxItem
            {
                Text = "", Value = ""
            };
            this.StoreList.Items.Add(defaultComboItem);
            while (dbReader.Read())
            {
                ComboboxItem comboItem = new ComboboxItem
                {
                    Text = db.NullToEmpty(dbReader, "store_name"),
                    Value = db.NullToEmpty(dbReader, "store_id")
                };
                this.StoreList.Items.Add(comboItem);
            }
            this.StoreList.AutoCompleteMode = AutoCompleteMode.Append;
            this.StoreList.DropDownStyle = ComboBoxStyle.DropDownList;
            this.StoreList.AutoCompleteSource = AutoCompleteSource.ListItems;
            dbReader.Close();
        }

        public void OrderLoad()
        {
            this.BuyCheckBox.Checked = true;
            this.SellCheckBox.Checked = true;
            OrderLoadWithOption();
        }
        public void OrderLoadWithOption()
        {
            bool isBuy = this.BuyCheckBox.Checked;
            bool isSell = this.SellCheckBox.Checked;
            try
            {
                db = new DbConnectorClass();
                String whereStr = "";
                if(isBuy && isSell)
                {
                    whereStr = "";
                }
                else if (isBuy)
                {
                    whereStr = "where isMarket = 1";
                }
                else if(isSell)
                {
                    whereStr = "where isMarket = 0";
                }
                else
                {
                    whereStr = "where isMarket = 2";
                }
                if(!this.OrderSearchDate.ToString("yyyy-MM-dd").Equals("0001-01-01"))
                {
                    whereStr += " and delivery_date = '" + this.OrderSearchDate.ToString("yyyy-MM-dd")+ "'";
                }
                if (!this.store_id.Equals(""))
                {
                    whereStr += " and t1.store_id = '"+this.store_id+"'";
                }
                adapter = new SqlDataAdapter(
                    "Select order_id as 'Order Id', store_name as Store, delivery_date as 'Delivery Date', ordered_date as 'Ordered Date', total as Total " +
                    "from dbo.order_list as t1 inner join dbo.store as t2 " +
                    "on t1.store_id = t2.store_id "+whereStr+ "  order by delivery_date desc, order_id desc;", db.GetConnection());
                // Create one DataTable with one column.
                this.DS = new DataSet();
                adapter.Fill(DS);
                this.OrderListView.DataSource = DS.Tables[0];
                this.OrderListView.AutoGenerateColumns = true;
                this.OrderListView.AutoResizeColumns();
                this.OrderListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddEditBtn()
        {
            DataGridViewButtonColumn EditBtnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            this.OrderListView.Columns.Add(EditBtnColumn);
            this.OrderListView.CellClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
            this.OrderListView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        // Calls the Employee.RequestStatus method.
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                this.OrderListView.Columns["Edit"].Index) return;

            // Retrieve the task ID.
            String orderId = (String)this.OrderListView[1, e.RowIndex].Value.ToString();
            CreateOrder cs = new CreateOrder(orderId, this);
            cs.Show();
        }

        private void OptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.showAllOrderCheckBox.Checked = false;
            OrderLoadWithOption();
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

        private void OrderDate_ValueChanged(object sender, EventArgs e)
        {
            this.DeliveryDate.CustomFormat = "MMM/dd/yy ddd";
            OrderSearchDate = this.DeliveryDate.Value;
            this.showAllOrderCheckBox.Checked = false;
            OrderLoad();
        }

        private void StoreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem item  = (ComboboxItem)this.StoreList.SelectedItem;
            this.store_id = item.Value.ToString();
            this.showAllOrderCheckBox.Checked = false;
            OrderLoad();
        }

        private void showAllOrderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showAllOrderCheckBox.Checked)
            {
                this.BuyCheckBox.Checked = true;
                this.SellCheckBox.Checked = true;
                this.StoreList.SelectedIndex = 0;
                this.store_id = "";
                this.DeliveryDate.CustomFormat = " ";
                this.OrderSearchDate = new DateTime(1, 1, 1);
                OrderLoadWithOption();
            }
            
        }
    }
}
