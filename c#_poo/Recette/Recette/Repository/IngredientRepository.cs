using Recette.Models;

namespace Recette.Repository
{
    public class IngredientRepository
    {

        private readonly DBContext _context;

        public IngredientRepository(DBContext context)
        {
            _context = context;
        }

        public List<Ingredient> All
        {
            get => _context.Ingredients.ToList();
        }
    }
}
