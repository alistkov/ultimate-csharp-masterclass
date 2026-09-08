using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.App;

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
        var shouldStop = false;
        var ingredients = new List<Ingredient>();

        while (!shouldStop)
        {
            Console.WriteLine("Add an ingredient by its ID, or type anything else if finished.");

            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out var id))
            {
                var selectedIngredient = _ingredientRegister.GetById(id);

                if (selectedIngredient is not null)
                {
                    ingredients.Add(selectedIngredient);
                }
            }
            else
            {
                shouldStop = true;
            }
        }

        return ingredients;
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}