// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var chedar = new Cheddar();
Console.WriteLine(chedar.PublicMethods());


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
{
    public string PublicMethods() =>
        "This method is PUBLIC in the Ingredient class";
    
    private string PrivateMethods() =>
        "This method is PRIVATE in the Ingredient class";
    
    protected string ProtectedMethods() =>
        "This method is PROTECTED in the Ingredient class";
}   

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