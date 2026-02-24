using Microsoft.EntityFrameworkCore;
using Recette.Models;

namespace Recette.Data
{
    public class DBContext : DbContext
    {



        public DbSet<RecetteIngredient> Recettes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecetteIngredient> Recette_Ingredients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecetteIngredient>()
                .HasKey(ri => new { ri.RecetteId, ri.IngredientId });
        }

    } }