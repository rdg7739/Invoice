using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;

namespace Invoice
{
    public partial class printWeeklyReport : Form
    {
        private DbConnectorClass db;
        DataSet myDataSet = new DataSet();
        SqlDataAdapter adapter;
        DataSet DS;
        DateTime deliveryDate;
        public printWeeklyReport(DateTime deliveryDate)
        {
            this.deliveryDate = deliveryDate;
            InitializeComponent();
        }

        private void printWeeklyReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.weeklyExpenseDataTable' table. You can move, or remove it, as needed.
            this.weeklyExpenseDataTableTableAdapter.Fill(this.DataSet1.weeklyExpenseDataTable, this.deliveryDate.ToString("yyyy-MM-dd"), this.deliveryDate.AddDays(1).ToString("yyyy-MM-dd"), 
                this.deliveryDate.AddDays(2).ToString("yyyy-MM-dd"), this.deliveryDate.AddDays(3).ToString("yyyy-MM-dd"), this.deliveryDate.AddDays(4).ToString("yyyy-MM-dd"));
            this.weeklyReportViewer.RefreshReport();
            try
            {
                DateTime Mondate = this.deliveryDate;
                DateTime Tuesdate = this.deliveryDate.AddDays(1);
                DateTime Wednesdate = this.deliveryDate.AddDays(2);
                DateTime Thursdate = this.deliveryDate.AddDays(3);
                DateTime Fridate = this.deliveryDate.AddDays(4);
                //expenseQuery
                db = new DbConnectorClass();
                String expenseQuery = "select s.Store_id as No, Store_name as Store, " +
                    "sum(case when delivery_date = '" + Mondate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as 'Monday', " +
                    "sum(case when delivery_date = '" + Tuesdate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as 'Tuesday', " +
                    "sum(case when delivery_date = '" + Wednesdate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as 'Wednesday', " +
                    "sum(case when delivery_date = '" + Thursdate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as 'Thursday', " +
                    "sum(case when delivery_date = '" + Fridate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as 'Friday', " +
                    "sum(case when delivery_date in ('" + Mondate.ToString("yyyy-MM-dd") + "','" +
                    Tuesdate.ToString("yyyy-MM-dd") + "','" + Wednesdate.ToString("yyyy-MM-dd") + "','" +
                    Thursdate.ToString("yyyy-MM-dd") + "','" + Fridate.ToString("yyyy-MM-dd") +
                    "') then total else 0 end) as Total " +
                    "from dbo.store as s " +
                    "left outer join dbo.order_list as o on o.store_id = s.store_id where isMarket = 1 " +
                    "group by s.Store_id, s.store_name;";
                adapter = new SqlDataAdapter(expenseQuery, db.GetConnection());
                // Create one DataTable with one column.
                DataSet expenseSet = new DataSet();
                adapter.Fill(expenseSet);

                //saleQuery
                db = new DbConnectorClass();
                String saleQuery = "select s.Store_id as No, Store_name as Store, " +
                    "sum(case when delivery_date = '" + Mondate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as 'Monday', " +
                    "sum(case when delivery_date = '" + Tuesdate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as 'Tuesday', " +
                    "sum(case when delivery_date = '" + Wednesdate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as 'Wednesday', " +
                    "sum(case when delivery_date = '" + Thursdate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as 'Thursday', " +
                    "sum(case when delivery_date = '" + Fridate.ToString("yyyy-MM-dd")
                    + "' then total else 0 end) as 'Friday', " +
                    "sum(case when delivery_date in ('" + Mondate.ToString("yyyy-MM-dd") + "','" +
                    Tuesdate.ToString("yyyy-MM-dd") + "','" + Wednesdate.ToString("yyyy-MM-dd") + "','" +
                    Thursdate.ToString("yyyy-MM-dd") + "','" + Fridate.ToString("yyyy-MM-dd") +
                    "') then total else 0 end) as Total " +
                    "from dbo.store as s " +
                    "left outer join dbo.order_list as o on o.store_id = s.store_id where isMarket = 0 " +
                    "group by s.Store_id, s.store_name;";
                adapter = new SqlDataAdapter(saleQuery, db.GetConnection());
                // Create one DataTable with one column.
                DataSet saleSet = new DataSet();
                adapter.Fill(saleSet);

                Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("delieveryDate", Mondate.ToString("(yyyy/MM/dd)") + " - "+Fridate.ToString("(yyyy/MM/dd)"))
                };
                ReportDataSource rds1 = new ReportDataSource("weeklyExpenseDataTable", expenseSet.Tables[0]);
                ReportDataSource rds2 = new ReportDataSource("weeklySaleDataTable", saleSet.Tables[0]);

                this.weeklyReportViewer.LocalReport.DataSources.Add(rds1);
                this.weeklyReportViewer.LocalReport.DataSources.Add(rds2);
                this.weeklyReportViewer.LocalReport.SetParameters(param);
                this.weeklyReportViewer.LocalReport.Refresh();
                this.weeklyReportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
