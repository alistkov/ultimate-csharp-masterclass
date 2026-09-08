namespace CookieCookbook.Recipes;

public interface IRecipesRepository
{
    void Write(string filePath, List<Recipe> strings);
    List<Recipe> Read(string filePath);
}