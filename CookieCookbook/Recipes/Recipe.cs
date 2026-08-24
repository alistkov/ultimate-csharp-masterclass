using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

public class Recipe(IEnumerable<Ingredient> ingredients)
{
    public IEnumerable<Ingredient> Ingredients { get; } = ingredients;
}

public class Sugar : Ingredient
{
    public override int Id => 5;
    public override string Name => "Sugar";
}