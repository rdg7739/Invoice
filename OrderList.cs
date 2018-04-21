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
    public partial class OrderList : Form
    {
        DbConnectorClass db;
        MySqlDataAdapter adapter;
        DataSet DS;
        public OrderList()
        {
            InitializeComponent();
            OrderLoad();
            AddEditBtn();
        }

        public void OrderLoad()
        {
            try
            { 
                db = new DbConnectorClass();
                adapter = new MySqlDataAdapter(
                    "Select order_id as `Order Id`, store_name as Store, delivery_date as `Delivery Date`, ordered_date as `Ordered Date`, total as Total "+
                    "from invoice_db.order as t1 inner join invoice_db.store as t2 "+
                    "on t1.store_id = t2.store_id order by delivery_date desc, order_id desc;" , db.GetConnection());
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
    }
}
