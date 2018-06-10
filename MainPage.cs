using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Invoice
{
    public partial class MainPage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public MainPage()
        {
            InitializeComponent();
        }

        private void CreateStore_Click(object sender, EventArgs e)
        {
            CreateOrder form2 = new CreateOrder();
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
        }
        
        private void DeliveryScheduleBtn_Click(object sender, EventArgs e)
        {
            DeliverySchedule form2 = new DeliverySchedule();
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
        }

        private void OrderListBtn_Click(object sender, EventArgs e)
        {
            OrderList form2 = new OrderList();
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
        }

        private void ItemListBtn_Click(object sender, EventArgs e)
        {
            ProductList form2 = new ProductList();
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
        }
        /*
        private void CreateStoreBtn_Click(object sender, EventArgs e)
        {
            CreateStore form2 = new CreateStore();
            form2.Show();
        }
        */
        private void MyStoreBtn_Click(object sender, EventArgs e)
        {
            MyStore form2 = new MyStore();
            form2.Show();
        }

        private void StoreListBtn_Click(object sender, EventArgs e)
        {
            StoreList form2 = new StoreList();
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
        }

     /*   private void CreatItemBtn_Click(object sender, EventArgs e)
        {
            CreateProduct form2 = new CreateProduct();
            form2.Show();
        }
        */
        private void WeeklySaleBtn_Click(object sender, EventArgs e)
        {
            WeeklySale form2 = new WeeklySale();
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
        }

        private void WeeklyExpenseBtn_Click(object sender, EventArgs e)
        {
            WeeklyExpense form2 = new WeeklyExpense();
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
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

        private void CatagoryBtn_Click(object sender, EventArgs e)
        {
            CreateCatagory form2 = new CreateCatagory();
            form2.Show();
        }
    }
}
