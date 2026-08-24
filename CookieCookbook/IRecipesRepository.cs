namespace CookieCookbook;

public interface IRecipesRepository
{
    void Write(object filePath, object allRecipes);
}