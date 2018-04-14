using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

public class DbConnectorClass
{
    private static String connectStr = "datasource=localhost;port=3306;username=root;password=root;";
    private MySqlConnection dbConnect;

    public DbConnectorClass()
	{
        dbConnect = new MySqlConnection(connectStr);
        dbConnect.Open();
    }

    public String NullToEmpty(MySqlDataReader dbReader, String columnName)
    {
        int idx = dbReader.GetOrdinal(columnName);
        if (dbReader.IsDBNull(idx))
        {
            return "";
        }
        return dbReader.GetString(idx);
    }
    public MySqlConnection GetConnection() {
        return this.dbConnect; 
    }
    public MySqlDataReader RunQuery(String query)
    {
        MySqlDataReader dbReader = null;

        MySqlCommand dbCmd = new MySqlCommand(query, dbConnect);
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
