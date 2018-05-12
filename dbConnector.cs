using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

public class DbConnectorClass
{
    private static string path = Path.GetFullPath(Environment.CurrentDirectory);
    private static string databaseName = "invoice_db.mdf";
    private SqlConnection dbConnect;

    public DbConnectorClass()
	{
        dbConnect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;"+
            "Initial Catalog = invoice_db;" +
            "AttachDbFilename =" + path + @"\" + databaseName+
            ";User ID = invoice_user; Password=invoice_user");
        dbConnect.Open();
    }
     public String NullToEmpty(SqlDataReader dbReader, String columnName)
    {
        int idx = dbReader.GetOrdinal(columnName);
        if (dbReader.IsDBNull(idx))
        {
            return "";
        }
        return dbReader.GetValue(idx).ToString();
    }
    public SqlConnection GetConnection() {
        return this.dbConnect; 
    }
    public SqlDataReader RunQuery(String query)
    {
        SqlDataReader dbReader = null;

        SqlCommand dbCmd = new SqlCommand(query, dbConnect);
        try
        {
            dbReader = dbCmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return dbReader;
    }
    public void Close()
    {
        dbConnect.Close();
    }

}
