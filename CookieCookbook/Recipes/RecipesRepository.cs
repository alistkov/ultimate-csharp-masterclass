using CookieCookbook.DataAccess;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

public class RecipesRepository(
    IStringsRepository stringsRepository, IIngredientRegister ingredientRegister
    ) : IRecipesRepository
{
    private readonly IStringsRepository _stringsRepository = stringsRepository;
    private readonly IIngredientRegister _ingredientRegister = ingredientRegister;
    private const string IdsSeparator = ", ";

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        var ingredientsId = new List<string>();

        foreach (var recipe in allRecipes)
        {
            var ids = new List<int>();
            foreach (var ingredient in recipe.Ingredients)
            {
                ids.Add(ingredient.Id);
            }
            ingredientsId.Add(string.Join(IdsSeparator, ids));
        }
        
        _stringsRepository.Write(filePath, ingredientsId);
    }

    public List<Recipe> Read(string filePath)
    {
        var recipesFromFile = _stringsRepository.Read(filePath);
        var recipes = new List<Recipe>();

        foreach (var recipeFromFile in recipesFromFile)
        {
            var recipe = RecipeFromString(recipeFromFile);
            recipes.Add(recipe);
        }

        return recipes;
    }

    private Recipe RecipeFromString(string recipeFromFile)
    {
        var ids = recipeFromFile.Split(IdsSeparator);
        var ingredients = new List<Ingredient>();

        foreach (var id in ids)
        {
            var parsedId = int.Parse(id);
            var ingredient = _ingredientRegister.GetById(parsedId);
            ingredients.Add(ingredient);
        }

        return new Recipe(ingredients);
    }
}