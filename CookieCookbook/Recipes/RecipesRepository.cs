using CookieCookbook.DataAccess;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

public class RecipesRepository(
    IStringsRepository stringsRepository,
    IIngredientsRegister ingredientsRegister)
    : IRecipesRepository
{
    private const string Separator = ",";

    public List<Recipe> Read(string filePath)
    {
        return stringsRepository.Read(filePath)
            .Select(RecipeFromString)
            .ToList();
    }

    private Recipe RecipeFromString(string recipeFromFile)
    {
        var ingredients = recipeFromFile.Split(Separator)
            .Select(int.Parse)
            .Select(ingredientsRegister.GetById);
        return new Recipe(ingredients);
    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        var recipesAsStrings = allRecipes
            .Select(recipe => string.Join(
                Separator,
                recipe.Ingredients.Select(ingredient => ingredient.Id)))
            .ToList();

        stringsRepository.Write(filePath, recipesAsStrings);
    }
}