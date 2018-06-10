using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Data;

namespace Invoice
{
    public partial class CreateCatagory : ResizeForm
    {
        private DbConnectorClass db;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        SqlDataAdapter adapter;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public CreateCatagory()
        {
            InitializeComponent();
            Catagory_Load();
            AddBtns();
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }

        private void Catagory_Load()
        {
            try
            {
                db = new DbConnectorClass();
                adapter = new SqlDataAdapter("select catagory_id, Catagory, SubCatagory from dbo.catagory order by CASE Catagory " +
                            "WHEN 'MEAT' THEN 1 WHEN 'FROZEN' THEN 2 WHEN 'PRODUCE' THEN 3 WHEN 'GROCERY' THEN 4  WHEN 'FRUIT' THEN 5 ELSE 6  END, Catagory, SubCatagory", db.GetConnection());
                // Create one DataTable with one column.
                DataSet DS = new DataSet();
                adapter.Fill(DS);
                this.CatagoryDataView.Rows.Clear();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    DataRow myRow = DS.Tables[0].Rows[i];
                    DataGridViewRow row = (DataGridViewRow)CatagoryDataView.Rows[0].Clone();
                    row.Cells[0].Value = myRow[0].ToString().Trim();
                    row.Cells[1].Value = myRow[1].ToString().Trim();
                    row.Cells[2].Value = myRow[2].ToString().Trim();
                    this.CatagoryDataView.Rows.Add(row);
                }
                //    this.ProductDataView.DataSource = DS.Tables[0];
                //    this.ProductDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddBtns()
        {
            DataGridViewButtonColumn SaveBtnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Save",
                Text = "Save",
                UseColumnTextForButtonValue = true
            };
            this.CatagoryDataView.Columns.Add(SaveBtnColumn);
            DataGridViewButtonColumn DeleteBtnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            this.CatagoryDataView.Columns.Add(DeleteBtnColumn);

        }
        // Calls the Employee.RequestStatus method.

        private void CatagoryDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            int rowNum = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.CatagoryDataView.Rows[rowNum];
                if (e.ColumnIndex == this.CatagoryDataView.Columns["Save"].Index)
                    SaveProduce(row);
                if (e.ColumnIndex == this.CatagoryDataView.Columns["Delete"].Index)
                    DeleteProduce(row);
            }
        }

        private void DeleteProduce(DataGridViewRow row)
        {
            // Retrieve the task ID.
            String catagoryId = row.Cells[0].Value.ToString();
            try
            {
                var x = MessageBox.Show("Are you sure you want to delete? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    String sqlQuery = "";
                    if (catagoryId.Equals(""))
                    {
                        this.CatagoryDataView.Rows.Remove(row);
                    }
                    else
                    {
                        sqlQuery = "Delete FROM dbo.catagory WHERE catagory_id = " + catagoryId;
                    }
                    db.RunQuery(sqlQuery).Close();
                    // need to close this form after click 'OK' button]
                    Catagory_Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveProduce(DataGridViewRow row)
        {
            // Retrieve the task ID.
            String catagoryId = "";
            String Catagory = "";
            String SubCatagory = "";
            if (row.Cells[0].Value != null)
                 catagoryId = row.Cells[0].Value.ToString();
            if (row.Cells[1].Value != null)
                Catagory = row.Cells[1].Value.ToString().ToUpper();
            if (row.Cells[2].Value != null)
                SubCatagory = row.Cells[2].Value.ToString().ToUpper();
            try
            {
                var x = MessageBox.Show("Are you sure you want to save? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == x)
                {
                    String sqlQuery = "";
                    if (catagoryId.Equals(""))
                    {
                        sqlQuery = "INSERT INTO dbo.Catagory " +
                        "(Catagory, subcatagory) VALUES (" +
                        " N'" + Catagory + "', " +
                        " N'" + SubCatagory + "') ";
                    }
                    else
                    {
                        sqlQuery = "UPDATE dbo.Catagory set " +
                        "Catagory = N'" + Catagory + "', " +
                        "SubCatagory = N'" + SubCatagory + "' WHERE catagory_id = " + catagoryId;
                    }
                    db.RunQuery(sqlQuery).Close();
                    // need to close this form after click 'OK' button
                    Catagory_Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
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
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
