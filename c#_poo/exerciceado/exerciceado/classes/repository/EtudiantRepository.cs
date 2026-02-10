using DocumentFormat.OpenXml.Office.Word;
using exerciceado.classes.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceado.classes.repository
{
    internal class EtudiantRepository
    {
        string connectionString = "Server=localhost;Uid=root;Pwd=;Database=ado";

        public void CreateTableEtudiant()
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();


                string query = """
                CREATE TABLE IF NOT EXISTS Etudiant (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    nom VARCHAR(255),
                    prenom VARCHAR(255),
                   date_de_naissance DATETIME,
                    email VARCHAR(255) UNIQUE
                );
                """;

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();


                }
            }
        }

        public Etudiant AfficherUnEtudiantParSonId(int id)
        {
            Etudiant etudiant = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Etudiant WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        etudiant= new Etudiant(
                        reader.GetInt32("id"),
                        reader.GetString("nom"),
                        reader.GetString("prenom"),
                        reader.GetDateTime("date_de_naissance"),
                        reader.GetString("email")
                         );
                    }
                }
            }
            return etudiant;
        }

        internal List<Etudiant> AfficherToutLesEtudiant()
        {
            throw new NotImplementedException();
        }

        internal void ModifierUnEtudiant(Etudiant etudiant)
        {
            throw new NotImplementedException();
        }

        
        internal void SupprimerUnEtudiant(int v)
        {
            throw new NotImplementedException();
        }

        internal void AjouterUnEtudiant(Etudiant etudiant)
        {
            throw new NotImplementedException();
        }
    }
}

