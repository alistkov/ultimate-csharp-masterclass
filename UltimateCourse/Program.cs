Ingredient ingredient = new Cheddar(2, 12);
// Cheddar cheddar = ingredient;
Ingredient randomIngredient = GenerateRandomIngredient();
Console.WriteLine("Random ingredient " + randomIngredient);

Console.WriteLine($"is object? {ingredient is object}");
Console.WriteLine($"is ingredient? {ingredient is Ingredient}");
Console.WriteLine($"is cheddar? {ingredient is Cheddar}");
Console.WriteLine($"is mozzarella? {ingredient is Mozzarella}");
Console.WriteLine($"is tomato sauce? {ingredient is TomatoSauce}");

// if (randomIngredient is Cheddar)
// {
//     Cheddar cheddar = (Cheddar)randomIngredient;
//     Console.WriteLine($"cheddar object {cheddar}");
// }

if (randomIngredient is Cheddar cheddar)
{
    Console.WriteLine($"cheddar object {cheddar}");
}

Ingredient GenerateRandomIngredient()
{
    var random = new Random();
    var number = random.Next(1, 4);
    if (number == 1)
    {
        return new Cheddar(2, 12);
    }

    if (number == 2)
    {
        return new TomatoSauce(1);
    }

    return new Mozzarella(2);
}

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public override string ToString() =>
        $"This is a pizza with {string.Join(", ", _ingredients)} ingredients";
}

public class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int PriceIfExtraTopping { get; }
    public virtual string Name { get; } = "Some ingredient";

    public int PublicField;

    public string PublicMethods() =>
        "This method is PUBLIC in the Ingredient class";

    private string PrivateMethods() =>
        "This method is PRIVATE in the Ingredient class";

    protected string ProtectedMethods() =>
        "This method is PROTECTED in the Ingredient class";

    public override string ToString() => Name;
}

public class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
}

public class ItalianFood
{
}

public class Cheddar : Ingredient
{
    public Cheddar(int priceIfExtraTopping, int agedForMonth) : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonth;
    }

    public override string Name => $"{base.Name}, more specifially, a Cheddar cheese for {AgedForMonths} months";

    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Tomato sauce";

    public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Mozzarella";

    public bool IsLight { get; }
}