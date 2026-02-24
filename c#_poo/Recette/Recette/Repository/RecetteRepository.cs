
namespace Recette.Repository
{
    public class RecetteRepository
    {
        private readonly DBContext _context;
        internal string Nom;
        internal int Id;

        public RecetteRepository(DBContext context)
        {
            _context = context;
        }

        public List<RecetteRepository> GetAll()
        {
            return _context.Recettes.ToList();
        }

        public RecetteRepository GetById(int id)
        {
            return _context.Recettes

                .Include(r => r.RecetteIngredients)
                    .ThenInclude(ri => ri.Ingredient)
                .FirstOrDefault(r => r.Id == id);
        }
    }


    public class DBContext
    {
        public object Recettes { get; internal set; }
        public object Ingredients { get; internal set; }
    }
}
