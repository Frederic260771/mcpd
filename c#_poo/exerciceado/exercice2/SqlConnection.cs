using MySql.Data.MySqlClient;

internal class SqlConnection
{
    private static string connectionString = "Server=localhost;Uid=root;Pwd=;Database=ado";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}