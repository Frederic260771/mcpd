using exerciceado.classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2.classe.repository
{
    internal class ClientRepository
    {

        public static void CreerTableClients()
        {
            using (MySqlConnection connection = SqlConnection.GetConnection())
            {
                connection.Open();

                string query = """
                                CREATE TABLE IF NOT EXISTS Clients (
                                    id INT AUTO_INCREMENT PRIMARY KEY,
                                    nom VARCHAR(255),
                                    prenom VARCHAR(255),
                                    adresse VARCHAR(255),
                                    codepostal VARCHAR(255)
                                    ville VARCHAR(255)
                                    telephone VARCHAR(255)

                                );
                                """;

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }


            }

            
        }

        internal static void AjouterUnClient(Client clientAInserer)
        {
            throw new NotImplementedException();
        }

        internal static object? RecupererToutLesClient()
        {
            throw new NotImplementedException();
        }

        internal static Client RecupereUnClientParSonId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
