using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace Invoice
{
    public partial class printPreview : Form
    {
        private DbConnectorClass db;
        DataSet myDataSet = new DataSet();
        SqlDataAdapter adapter;
        DataSet DS;
        private SqlDataReader dbReader;
        String total;
        String orderId;
        String delieveryDateLbl;
        public printPreview(String orderId, String total)
        {
            this.orderId = orderId;
            this.total = total;
            InitializeComponent();
        }

        private void printPreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.weeklyExpenseDataTable' table. You can move, or remove it, as needed.
            this.weeklyExpenseDataTableTableAdapter.Fill(this.DataSet1.weeklyExpenseDataTable, delieveryDateLbl, delieveryDateLbl, delieveryDateLbl, delieveryDateLbl, delieveryDateLbl);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string storeIdLbl = "";
            string orderIdLbl = "";
            string totalLbl = "";
            string custNameLbl = "";
            string custAddrLbl = "";
            string custPhoneLbl = "";
            string storeNameLbl = "";
            string addressLbl = "";
            string telLabel = "";
            string faxLbl = "";
            db = new DbConnectorClass();
            dbReader = db.RunQuery("select * from dbo.store as s inner join dbo.order_list as o " +
                    "on s.store_id = o.store_id where order_id = " + orderId + ";");
            if (dbReader.Read())
            {
                storeIdLbl = db.NullToNA(dbReader, "store_id").PadLeft(5,'0');
                orderIdLbl = this.orderId.PadLeft(5,'0');
                delieveryDateLbl = db.NullToNA(dbReader, "delivery_date");
                

                totalLbl = this.total;
                custNameLbl = db.NullToNA(dbReader, "store_name");
                custAddrLbl = db.NullToNA(dbReader, "store_address");
                custPhoneLbl = db.NullToNA(dbReader, "store_phone");
            }
            dbReader.Close();

            dbReader = db.RunQuery("select * from dbo.store where store_id = 1;");
            if (dbReader.Read())
            {
                storeNameLbl = db.NullToNA(dbReader, "store_name");
                addressLbl = db.NullToNA(dbReader, "store_address");
                telLabel = db.NullToNA(dbReader, "store_phone");
                faxLbl = db.NullToNA(dbReader, "store_fax");
            }
            dbReader.Close();
            DateTime parsedDate = DateTime.Parse(delieveryDateLbl);
            delieveryDateLbl = parsedDate.ToString("MM-dd-yyyy");

            Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("orderId", orderIdLbl),
                new Microsoft.Reporting.WinForms.ReportParameter("storeId", storeIdLbl),
                new Microsoft.Reporting.WinForms.ReportParameter("delieveryDate", delieveryDateLbl),
                new Microsoft.Reporting.WinForms.ReportParameter("total", totalLbl),
                new Microsoft.Reporting.WinForms.ReportParameter("custName", custNameLbl),
                new Microsoft.Reporting.WinForms.ReportParameter("custAddr", custAddrLbl),
                new Microsoft.Reporting.WinForms.ReportParameter("custPhone", custPhoneLbl),
                new Microsoft.Reporting.WinForms.ReportParameter("storeName", storeNameLbl),
                new Microsoft.Reporting.WinForms.ReportParameter("storeAddr", addressLbl),
                new Microsoft.Reporting.WinForms.ReportParameter("storeTel", telLabel),
                new Microsoft.Reporting.WinForms.ReportParameter("storeFax", faxLbl)
            };
            this.reportViewer1.LocalReport.SetParameters(param);
            try
            {
                db = new DbConnectorClass();
                adapter = new SqlDataAdapter("SELECT Product, Box, Each, Pound," +
                    "Price, (price * (Box + Each + Pound)) AS Amount, Note " +
                    "FROM dbo.cart where (box + each + pound) > 0 and order_id = " + orderId, db.GetConnection());
                // Create one DataTable with one column.
                this.DS = new DataSet();
                adapter.Fill(DS);
                ReportDataSource rds = new ReportDataSource("Order", DS.Tables[0]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
