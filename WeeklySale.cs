using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace Invoice
{
    public partial class WeeklySale : ResizeForm
    {
        private DbConnectorClass db;
        private SqlDataAdapter adapter;
        private DataSet DS;
        private int MONDAY = 2;
        private int TUESDAY = 3;
        private int WEDNESDAY = 4;
        private int THURSDAY = 5;
        private int FRIDAY = 6;
        private int WEEKLYTOTAL = 7;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public WeeklySale()
        {
            InitializeComponent();
            LoadWeeklySale();
        }

        private void LoadWeeklySale()
        {
            try
            {
                DateTime Mondate = GetMonday();
                DateTime Tuesdate = GetMonday().AddDays(1);
                DateTime Wednesdate = GetMonday().AddDays(2);
                DateTime Thursdate = GetMonday().AddDays(3);
                DateTime Fridate = GetMonday().AddDays(4);
                decimal MonTotal = 0;
                decimal TuesTotal = 0;
                decimal WedTotal = 0;
                decimal ThurTotal = 0;
                decimal FriTotal = 0;
                decimal WeeklyTotal = 0;
                String MonStr = "Mon (" + Mondate.ToString("MM-dd") + ")";
                String TuesStr = "Tues (" + Tuesdate.ToString("MM-dd") + ")";
                String WedStr = "Wednes (" + Wednesdate.ToString("MM-dd") + ")";
                String ThurStr = "Thurs (" + Thursdate.ToString("MM-dd") + ")";
                String FriStr = "Fri (" + Fridate.ToString("MM-dd") + ")";
                db = new DbConnectorClass();
                String query = "select s.Store_id as No, Store_name as Store, " +
                    "sum(case when delivery_date = '" + Mondate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as '"+MonStr+"', " +
                    "sum(case when delivery_date = '" + Tuesdate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as '"+TuesStr+"', " +
                    "sum(case when delivery_date = '" + Wednesdate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as '"+WedStr+"', " +
                    "sum(case when delivery_date = '" + Thursdate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as '"+ThurStr+"', " +
                    "sum(case when delivery_date = '" + Fridate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as '"+FriStr+"', " +
                    "sum(case when delivery_date in ('" + Mondate.ToString("yyyy-MM-dd") + "','" +
                    Tuesdate.ToString("yyyy-MM-dd") + "','" + Wednesdate.ToString("yyyy-MM-dd") + "','" +
                    Thursdate.ToString("yyyy-MM-dd") + "','" + Fridate.ToString("yyyy-MM-dd") +
                    "') then total else 0 end) as Total " +
                    "from dbo.store as s " +
                    "left outer join dbo.order_list as o on o.store_id = s.store_id where isMarket = 0 " +
                    "group by s.Store_id, s.store_name;";
                adapter = new SqlDataAdapter(query, db.GetConnection());
                // Create one DataTable with one column.
                this.DS = new DataSet();
                adapter.Fill(DS);
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    DataRow dataRow = DS.Tables[0].Rows[i];
                    MonTotal += Decimal.Parse(dataRow[MONDAY].ToString());
                    TuesTotal += Decimal.Parse(dataRow[TUESDAY].ToString());
                    WedTotal += Decimal.Parse(dataRow[WEDNESDAY].ToString());
                    ThurTotal += Decimal.Parse(dataRow[THURSDAY].ToString());
                    FriTotal += Decimal.Parse(dataRow[FRIDAY].ToString());
                    WeeklyTotal += Decimal.Parse(dataRow[WEEKLYTOTAL].ToString());
                }
                DataRow newRow = DS.Tables[0].NewRow();
                newRow["No"] = 999;
                newRow["Store"] = "Total";
                newRow[MonStr] = MonTotal;
                newRow[TuesStr] = TuesTotal;
                newRow[WedStr] = WedTotal;
                newRow[ThurStr] = ThurTotal;
                newRow[FriStr] = FriTotal;
                newRow["Total"] = WeeklyTotal;

                DS.Tables[0].Rows.Add(newRow);
                this.WeeklySaleDataView.DataSource = DS.Tables[0];
                this.WeeklySaleDataView.AutoGenerateColumns = true;
                this.WeeklySaleDataView.AutoResizeColumns();
                this.WeeklySaleDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadWeeklySale();
        }

        private DateTime GetMonday()
        {
            DateTime pickedDate = this.WeeklySaleDateTimePicker.Value;

            // lastMonday is always the Monday before nextSunday.
            // When date is a Sunday, lastMonday will be tomorrow.     
            int offset = pickedDate.DayOfWeek - DayOfWeek.Monday;
            return pickedDate.AddDays(-offset);
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
