using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Invoice
{
    public partial class ProductList : Form
    {
        private DbConnectorClass db;
        private SqlDataAdapter adapter;
        public ProductList()
        {
            InitializeComponent();
            GetProductList();
            AddEditBtn();
        }
        public void GetProductList() {
            try
            {
                db = new DbConnectorClass();
                adapter = new SqlDataAdapter("select product_id as No,Product, Price, Quantity, Note from invoice.dbo.product", db.GetConnection());
                // Create one DataTable with one column.
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                this.ProductDataView.DataSource = DS.Tables[0];
                this.ProductDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            this.ProductDataView.Columns.Add(EditBtnColumn);
            this.ProductDataView.CellClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
            this.ProductDataView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        // Calls the Employee.RequestStatus method.
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                this.ProductDataView.Columns["Edit"].Index) return;

            // Retrieve the task ID.
            String productId = (String)this.ProductDataView[1,e.RowIndex].Value.ToString();
            CreateProduct cp = new CreateProduct(productId, this);
            cp.Show();
        }

        private void ProductDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
