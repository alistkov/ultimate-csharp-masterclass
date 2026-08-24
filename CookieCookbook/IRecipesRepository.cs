using CookieCookbook.Recipes;

namespace CookieCookbook;

public interface IRecipesRepository
{
    void Write(string filePath, List<Recipe> strings);
    List<Recipe> Read(string filePath);
}