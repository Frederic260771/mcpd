using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3.classes
{
    internal class Ingredient(int? id, string description, string nom)
    {

        public int? Id { get; set; } = id;

        public string Nom { get; set; } = nom;
        public string Description { get; set; } = description;
        public int IngredientId { get; internal set; }

        public override string ToString()
        {
            return $"Ingredient{Id} Nom {Nom} Description {Description}";
        }






    }
}
