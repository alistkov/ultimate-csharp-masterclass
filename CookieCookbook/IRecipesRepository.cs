using CookieCookbook.Recipes;

namespace CookieCookbook;

public interface IRecipesRepository
{
    void Write(object filePath, object allRecipes);
    List<Recipe> Read(string filePath);
}