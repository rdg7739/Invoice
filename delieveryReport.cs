using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;

namespace Invoice
{
    public partial class delieveryReport : Form
    {
        DataSet myDataSet = new DataSet();
        DateTime delieveryDate;
        DbConnectorClass db;
        SqlDataAdapter adapter;
        DataSet DS;
        public delieveryReport(DateTime delieveryDate)
        {
            InitializeComponent();
            this.delieveryDate = delieveryDate;
        }

        private void delieveryReport_Load(object sender, EventArgs e)
        {
            db = new DbConnectorClass();
            String query = "select product, " +
                "CONCAT(" +
                "sum(case when route = 1 then box else 0 end), ' box, ', " +
                "sum(case when route = 1 then each else 0 end), ' each, ', " +
                "sum(case when route = 1 then pound else 0 end), ' pound') as 'route1', " +
                "CONCAT(" +
                "sum(case when route = 2 then box else 0 end), ' box, ', " +
                "sum(case when route = 2 then each else 0 end), ' each, ', " +
                "sum(case when route = 2 then pound else 0 end), ' pound') as 'route2', " +
                "CONCAT(" +
                "sum(case when route = 3 then box else 0 end), ' box, ', " +
                "sum(case when route = 3 then each else 0 end), ' each, ', " +
                "sum(case when route = 3 then pound else 0 end), ' pound') as 'route3' " +
                "from dbo.cart as c where order_id in " +
                "(select order_id from dbo.order_list as o inner join dbo.store as s " +
                "on s.store_id = o.store_id where isMarket = '0' AND delivery_date = '" +
                    delieveryDate.ToString("yyyy-MM-dd") +
                "') group by c.Product;";
            adapter = new SqlDataAdapter(query, db.GetConnection());
            // Create one DataTable with one column.
            this.DS = new DataSet();
            adapter.Fill(DS);
            ReportDataSource rds = new ReportDataSource("delieverySchedule", DS.Tables[0]);
            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.DataSources.Add(rds);
            // TODO: This line of code loads data into the 'DataSet1.weeklyExpenseDataTable' table. You can move, or remove it, as needed.
            Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("delieveryDate", delieveryDate.ToString("MM-dd-yyyy")),
            };
            this.reportViewer2.LocalReport.SetParameters(param);
            this.reportViewer2.LocalReport.Refresh();
            this.reportViewer2.RefreshReport();
        }
    }
}
