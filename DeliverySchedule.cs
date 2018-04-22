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
    public partial class DeliverySchedule : Form
    {
        DbConnectorClass db;
        MySqlDataAdapter adapter;
        DataSet DS;
        private int PRODUCT = 0;
        //private int QTY = 1;
        //private int PRICE = 2;
        //private int AMOUNT = 3;
        private int MARKET = 4;
        private int NOTE = 5;
       // private int ROUTE = 6,7,8;

        public DeliverySchedule()
        {
            InitializeComponent();
            OrderLoad();
        }
        public void OrderLoad()
        {
            try
            {
                db = new DbConnectorClass();
                adapter = new MySqlDataAdapter(
                    "select product, sum(quantity) as QTY, Price, (price * quantity) as Amount, Market, Note, "+
                    "sum(case when route = 1 then quantity else 0 end) as `route 1`, " +
                    "sum(case when route = 2 then quantity else 0 end) as `route 2`, "+
                    "sum(case when route = 3 then quantity else 0 end) as `route 3` "+
                    "from invoice_db.cart where order_id in " +
                    "(select order_id from invoice_db.order as o inner join invoice_db.store as s " +
                    "on s.store_id = o.store_id where isMarket = '0' AND delivery_date = '" +
                Convert.ToDateTime(this.DeliveryScheduleDate.Value.ToString()).ToString("yyyy-MM-dd")+
                    "') group by product;", db.GetConnection());
                // Create one DataTable with one column.
                this.DS = new DataSet();
                adapter.Fill(DS);
                this.DeliveryScheduleView.DataSource = DS.Tables[0];
                this.DeliveryScheduleView.AutoGenerateColumns = true;
                this.DeliveryScheduleView.AutoResizeColumns();
                this.DeliveryScheduleView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeliveryScheduleDate_ValueChanged(object sender, EventArgs e)
        {
            OrderLoad();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //myDataSet.AcceptChanges();EDIT:Don't know why, but this line wasn't letting the chane in db happen.
            try
            {
                var x = MessageBox.Show("Are you sure you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    for (int i = 0; i < this.DeliveryScheduleView.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = this.DeliveryScheduleView.Rows[i];
                        String product = row.Cells[PRODUCT].Value.ToString();
                        String market = row.Cells[MARKET].Value.ToString();
                        String note = row.Cells[NOTE].Value.ToString();
                        string InsertSql = "update invoice_db.cart set market='"+market+"', note='"+note+"' where order_id in "+
                        "(select order_id from invoice_db.order where delivery_date = '"+
                        Convert.ToDateTime(this.DeliveryScheduleDate.Value.ToString()).ToString("yyyy-MM-dd") + "') "+
                        "and product = '"+ product + "'";
                        db.RunQuery(InsertSql).Close();
                }
                MessageBox.Show("Data Saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.None);
                    // need to close createStore form after click 'OK' button
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
