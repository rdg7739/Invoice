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
        bool isModified = false;
        public OrderList()
        {
            InitializeComponent();
            OrderLoad(true, true);
            AddBtns();
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }
        public OrderList(bool isBuy, bool isSell, DateTime searchDate)
        {
            OrderLoad(isBuy, isSell, searchDate, "");
            AddBtns();
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }
        public OrderList(bool isBuy, bool isSell, DateTime searchDate, String storeId)
        {
            OrderLoad(isBuy, isSell, searchDate, storeId);
            AddBtns();
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }

        public void OrderLoad(bool isBuy, bool isSell, DateTime searchDate, String storeId)
        {
            InitializeComponent();
            if(!searchDate.ToString("yyyy-MM-dd").Equals("0001-01-01"))
                this.DeliveryDate.Value = searchDate;
            this.OrderSearchDate = searchDate;
            this.store_id = storeId;
            OrderLoad(isBuy, isSell);
            if (storeId != null && !storeId.Equals(""))
            {
                SqlDataReader dbReader = db.RunQuery("select * from dbo.store where store_id = " + storeId + ";");
                if (dbReader.Read())
                {
                    this.StoreList.SelectedIndex = this.StoreList.FindString(db.NullToNA(dbReader, "store_name"));
                }
                dbReader.Close();
            }
        }

        public void OrderLoad(bool isBuy, bool isSell)
        {
            this.BuyCheckBox.Checked = isBuy;
            this.SellCheckBox.Checked = isSell;
            OrderLoadWithOption();            
            for(int i = 0; i < this.OrderListView.ColumnCount; i++)
            {
                OrderListView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
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
                    "Select order_id as 'Order Id', store_name as Store, store_phone as Phone, store_fax as Fax, store_address as Address, delivery_date as 'Delivery Date', ordered_date as 'Ordered Date', total as Total " +
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

        private void AddBtns()
        {
            SqlDataReader dbReader = db.RunQuery("select s.store_id, store_name, store_phone, store_address, contact_name, contact_phone, store_detail, store_fax, isMarket, count(*) as count " +
" from dbo.store as s full outer join dbo.order_list as o on s.store_id = o.store_id " +
" group by s.store_id, store_name, store_phone, store_address, contact_name, contact_phone, store_detail, store_fax, isMarket order by count(*) desc; ");
            ComboboxItem defaultComboItem = new ComboboxItem
            {
                Text = "",
                Value = ""
            };
            this.StoreList.Items.Add(defaultComboItem);
            while (dbReader.Read())
            {
                ComboboxItem comboItem = new ComboboxItem
                {
                    Text = db.NullToNA(dbReader, "store_name"),
                    Value = db.NullToNA(dbReader, "store_id")
                };
                this.StoreList.Items.Add(comboItem);
            }
            this.StoreList.AutoCompleteMode = AutoCompleteMode.Append;
            this.StoreList.DropDownStyle = ComboBoxStyle.DropDownList;
            this.StoreList.AutoCompleteSource = AutoCompleteSource.ListItems;
            dbReader.Close();
            DataGridViewButtonColumn EditBtnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn DeleteBtnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn InvoiceBtnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Invoice",
                Text = "Invoice",
                UseColumnTextForButtonValue = true
            };
            this.OrderListView.Columns.Add(EditBtnColumn);
            this.OrderListView.Columns.Add(DeleteBtnColumn);
            this.OrderListView.Columns.Add(InvoiceBtnColumn);
            this.OrderListView.CellClick -= new DataGridViewCellEventHandler(DataGridView_CellClick);
            this.OrderListView.CellClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
            this.OrderListView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // Calls the Employee.RequestStatus method.
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderIdx = this.OrderListView.Columns["Order Id"].Index;
            int invoiceIdx = this.OrderListView.Columns["Invoice"].Index;
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex > -1 && e.RowIndex < this.OrderListView.RowCount-1) {
                String orderId = (String)this.OrderListView[orderIdx, e.RowIndex].Value.ToString();
                if (e.ColumnIndex == this.OrderListView.Columns["Edit"].Index)
                {
                    // Retrieve the task ID.
                    CreateOrder cs = new CreateOrder(orderId, this);
                    cs.Show();
                }
                else if (e.ColumnIndex == this.OrderListView.Columns["Delete"].Index)
                {
                    try
                    {
                        var x = MessageBox.Show("Do you want to delete? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == x)
                        {
                            String sqlQuery = "DELETE FROM dbo.cart WHERE order_id= " + orderId;
                            db.RunQuery(sqlQuery).Close();
                            sqlQuery = "DELETE FROM dbo.order_list WHERE order_id= " + orderId;
                            db.RunQuery(sqlQuery).Close();
                            MessageBox.Show("Data Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.None);
                            // need to close this form after click 'OK' button
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    OrderLoad(true, true);
                }
                else if (e.ColumnIndex == this.OrderListView.Columns["Invoice"].Index)
                {
                    // Retrieve the task ID.
                    String totalTxt = (String)this.OrderListView[invoiceIdx, e.RowIndex].Value.ToString();
                    printPreview preview = new printPreview(orderId, totalTxt);
                    preview.Show();
                }
            }
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
            OrderLoad(true, true);
        }

        private void StoreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem item  = (ComboboxItem)this.StoreList.SelectedItem;
            this.store_id = item.Value.ToString();
            this.showAllOrderCheckBox.Checked = false;
            OrderLoad(true, true);
        }

        private void ShowAllOrderCheckBox_CheckedChanged(object sender, EventArgs e)
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
