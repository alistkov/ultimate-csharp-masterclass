using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook;

public class RecipesConsoleUserInteraction(IngredientRegister ingredientRegister) : IRecipesUserInteraction
{
    private readonly IngredientRegister _ingredientRegister = ingredientRegister;

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
        Console.WriteLine("Create a new cookie recipe! Available ingredients are: ");

        foreach (var ingredient in _ingredientRegister.All)
        {
            Console.WriteLine(ingredient);
        }
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