using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3.repository
{
    internal class recetteingredientrepository
    {
        string query = """ 
        CREATE TABLE Recette (
           id INT AUTO_INCREMENT PRIMARY KEY,
          recette_id INT,
        CONSTRAINT FK_recette_ingredient_recette_id FOREIGN KEY (recette_id) REFERENCES recette(id)
           quantite VARCHAR(10) NOT NULL,
        ingredient_id INT,
        CONSTRAINT FK_ingredient_recette_ingredient_id FOREIGN KEY (ingredient_id) REFERENCES ingredient(id)



             );

        """;
        




    }
}
