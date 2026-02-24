namespace Recette.DTOs
{
    public class RecetteDetailDto
    {

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public List<IngredientDetailDto> Ingredients { get; set; }
    }





}
}
