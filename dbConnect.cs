using System;
using MySql.Data.MySqlClient;

public class dbConnectClass
{
    private static String connectStr = "datasource=localhost;port=3306;username=root;password=root;";
    private MySqlConnection dbConnect;

    public dbConnectClass()
	{
        dbConnect = new MySqlConnection(connectStr);
    }

    private String nullToEmpty(String columnName)
    {
        int idx = dbReader.GetOrdinal(columnName);
        if (dbReader.IsDBNull(idx))
        {
            return "";
        }
        return dbReader.GetString(idx);
    }

    public MySqlDataReader runQuery(String query)
    {
        MySqlDataReader dbReader = null;

        MySqlCommand dbCmd = new MySqlCommand("select * from dbo.store where store_id = 1", dbConnect);
        try
        {
            dbConnect.Open();
            dbReader = dbCmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return dbReader;
    }


}
