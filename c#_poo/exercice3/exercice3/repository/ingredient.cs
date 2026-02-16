using exercice3.classes;

namespace exercice3.repository
{
    internal class ingredient : Ingredient
    {
        public int IngredientId { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
    }
}