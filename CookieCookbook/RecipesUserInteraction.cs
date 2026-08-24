using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook;

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are:" + Environment.NewLine);

            var recipeIndex = 1;
            foreach (var recipe in allRecipes)
            {
                Console.WriteLine($"*****{recipeIndex}*****");
                Console.WriteLine(recipe);
                Console.WriteLine();
                recipeIndex += 1;
            }
        }
    }

    public void PromptToCreateRecipe()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Ingredient> ReadIngredientsFromUser()
    {
        throw new NotImplementedException();
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}