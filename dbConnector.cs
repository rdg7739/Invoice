using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

public class dbConnectorClass
{
    private static String connectStr = "datasource=localhost;port=3306;username=root;password=root;";
    private MySqlConnection dbConnect;

    public dbConnectorClass()
	{
        dbConnect = new MySqlConnection(connectStr);
        dbConnect.Open();
    }

    public String nullToEmpty(MySqlDataReader dbReader, String columnName)
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
