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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CreateStore_Click(object sender, EventArgs e)
        {
            CreateOrder form2 = new CreateOrder();
            form2.Show();
        }
        
        private void DeliveryScheduleBtn_Click(object sender, EventArgs e)
        {
            DeliverySchedule form2 = new DeliverySchedule();
            form2.Show();
        }

        private void OrderListBtn_Click(object sender, EventArgs e)
        {
            OrderList form2 = new OrderList();
            form2.Show();
        }

        private void ItemListBtn_Click(object sender, EventArgs e)
        {
            ProductList form2 = new ProductList();
            form2.Show();
        }

        private void CreateStoreBtn_Click(object sender, EventArgs e)
        {
            CreateStore form2 = new CreateStore();
            form2.Show();
        }

        private void MyStoreBtn_Click(object sender, EventArgs e)
        {
            MyStore form2 = new MyStore();
            form2.Show();
        }

        private void StoreListBtn_Click(object sender, EventArgs e)
        {
            StoreList form2 = new StoreList();
            form2.Show();
        }

        private void CreatItemBtn_Click(object sender, EventArgs e)
        {
            CreateProduct form2 = new CreateProduct();
            form2.Show();
        }
    }
}
