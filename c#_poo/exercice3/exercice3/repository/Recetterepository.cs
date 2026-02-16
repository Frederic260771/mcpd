using exercice3.classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace exercice3.repository
{
    internal class Recetterepository
    {



        string query = """
        CREATE TABLE Recette (
           id INT AUTO_INCREMENT PRIMARY KEY,
           nom VARCHAR(50),NOT NULL
           description VARCHAR(200), NOT NULL
            instruction VARCHAR(MAX),NOT NULL
             );
        """;


        public List<Recette> GetAll()
        {
            List<Recette> list = new List<Recette>();

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Recette";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Recette
                    {
                        RecetteId = (int)reader["recette_id"],
                        Nom = reader["nom"].ToString(),
                        Description = reader["description"].ToString(),
                        Instructions = reader["instructions"].ToString()
                    });
                }
            }

            return list;
        }




    }
}
