using exercice3.classes;
using exercice3.repository;

{
    RecetteRepository repo = new RecetteRepository();

    Recette recette = new()
    {
        Nom = "Pâtes Carbonara",
        Description = "Recette italienne",
        Instructions = "Mélanger et cuire..."
    };
    object value1;
    object _ = recette.Ingredients.Add(new RecetteIngredient
    {
        IngredientId = 1,
        Quantite = "200g"
    });

    object value = recette.Ingredients.Add(new RecetteIngredient
    {
        IngredientId = 2,
        Quantite = "3 pièces"
    });

    repo.Add(recette);

    Console.WriteLine("Recette ajoutée !");
}

