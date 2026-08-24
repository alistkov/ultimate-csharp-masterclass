namespace CookieCookbook;

public class CookiesRecipesApp(RecipesRepository recipesRepository, RecipesUserInteraction recipesUserInteraction)
{
    private readonly RecipesRepository _recipesRepository = recipesRepository;
    private readonly RecipesUserInteraction _recipesUserInteraction = recipesUserInteraction;

    public void Run()
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesUserInteraction.PromptToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count > 0)
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteraction.ShowMessage("Recipe added:");
            _recipesUserInteraction.ShowMessage(recipe.toString());
        }
        else
        {
            _recipesUserInteraction.PrintMessage("No ingredients have been selected. Recipe will not be saved");
        }

        _recipesUserInteraction.Exit();
    }
}