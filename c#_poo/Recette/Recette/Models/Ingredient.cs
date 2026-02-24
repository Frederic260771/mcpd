using System.ComponentModel.DataAnnotations;

namespace Recette.Models
{
    public class Ingredient
    {


        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nom { get; set; }

        
        public ICollection<RecetteIngredient> RecetteIngredients { get; set; }




    }
}
