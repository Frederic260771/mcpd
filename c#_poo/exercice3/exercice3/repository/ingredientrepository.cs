using exercice3.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3.repository
{
    internal class ingredientrepository
    {

        string query = """
        CREATE TABLE Ingredient (
           id INT AUTO_INCREMENT PRIMARY KEY,
           nom VARCHAR(50),NOT NULL
           description VARCHAR(200), NOT NULL
            
             );
        """;



        private readonly Database db = new Database();

        public List<Ingredient> GetAll()
        {
            List<Ingredient> list = new List<Ingredient>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Ingredient";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new ingredient
                    {
                        IngredientId = (int)reader["ingredient_id"],
                        Nom = reader["nom"].ToString(),
                        Description = reader["description"].ToString()
                    });
                }
            }

            return list;
        }

        public void Add(Ingredient ingredient)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO Ingredient (nom, description) VALUES (@nom, @desc)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", ingredient.Nom);
                cmd.Parameters.AddWithValue("@desc", ingredient.Description);

                cmd.ExecuteNonQuery();
            }
        }
    }


}
}
