using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace Invoice
{
    public partial class OrderList : Form
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
        public OrderList()
        {
            InitializeComponent();
            OrderLoad();
            AddEditBtn();
        }

        public void OrderLoad()
        {
            this.BuyCheckBox.Checked = true;
            this.SellCheckBox.Checked = true;
            OrderLoad(true, true);
        }
        public void OrderLoad(bool isBuy, bool isSell)
        {
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
                
                adapter = new SqlDataAdapter(
                    "Select order_id as 'Order Id', store_name as Store, delivery_date as 'Delivery Date', ordered_date as 'Ordered Date', total as Total " +
                    "from invoice.dbo.order_list as t1 inner join invoice.dbo.store as t2 " +
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
            bool isBuy = this.BuyCheckBox.Checked;
            bool isSell = this.SellCheckBox.Checked;
            OrderLoad(isBuy, isSell);
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
            OrderLoad();
        }
    }
}
