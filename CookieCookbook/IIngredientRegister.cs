using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook;

public interface IIngredientRegister
{
    IEnumerable<Ingredient> All { get; }
    Ingredient GetById(int id);
}