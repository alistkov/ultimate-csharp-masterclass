// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public string Describe() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{}

public class Cheddar : Ingredient
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
    public string Name => "Tomato sauce";
    public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public string Name => "Mozzarella";
    public int AgedForMonths { get; }
}