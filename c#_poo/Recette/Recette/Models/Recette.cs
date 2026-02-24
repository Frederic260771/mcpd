using System.ComponentModel.DataAnnotations;

namespace Recette.Models
{
    public class Recette
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Titre { get; set; }

        [Required]
        public string Description { get; set; }

       

        
        public ICollection<RecetteIngredient> RecetteIngredients { get; set; }



    }

   
}
