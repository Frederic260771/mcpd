using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recette.Models
{
    public class RecetteIngredient
    {

        public int RecetteId { get; set; }
        public Recette Recette { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }



    }
}
