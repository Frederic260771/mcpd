using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace exercice3.repository
{
    internal class Database
    {
        private static readonly string connectionString =
        "Server=localhost;Database=RecettesDB;uid=root;pwd=;";


        internal static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
