using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DbConnectorClass
{
    private static String connectStr =
        "Data Source=(localdb)\\MSSQLLocalDB;" +
        "Initial Catalog = invoice; " +
        "Integrated Security = False;" +
        "User ID=invoice_user;Password=invoice_user" +
        "Connect Timeout=30;Encrypt=False;" +
        "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
        "MultiSubnetFailover=False";

    private SqlConnection dbConnect;

    public DbConnectorClass()
	{
        dbConnect = new SqlConnection(connectStr);
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
