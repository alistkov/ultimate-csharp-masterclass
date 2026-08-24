using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook;

public class RecipesRepository : IRecipesRepository
{
    public void Write(object filePath, object allRecipes)
    {
        throw new NotImplementedException();
    }

    public List<Recipe> Read(string filePath)
    {
        return new List<Recipe>
        {
            new Recipe(new List<Ingredient>
            {
                new WheatFlour(),
                new Butter(),
                new Sugar()
            }),
            new Recipe(new List<Ingredient>
            {
                new CocoaPowder(),
                new SpeltFlour(),
                new Cinnamon()
            })
        };
    }
}