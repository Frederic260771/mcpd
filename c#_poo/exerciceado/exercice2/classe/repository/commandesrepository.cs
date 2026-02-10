using exerciceado.classes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exercice2.classe.repository
{
    internal class CommandesRepository
    {

        public static void CreerTableCommandes()
        {
            using (MySqlConnection connection = SqlConnection.GetConnection())
            {
                connection.Open();

                string query = """
                                CREATE TABLE IF NOT EXISTS Clients (
                                    id INT AUTO_INCREMENT PRIMARY KEY,
                                   clientid VARCHAR(255),
                                    date DATETIME,
                                    total DECIMAL(255),

                                );
                                """;

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }




            }
        }
    }
}