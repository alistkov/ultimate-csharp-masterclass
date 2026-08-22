var cheddar = new Cheddar(2, 3);
Console.WriteLine(cheddar);

// var pizza = new Pizza();
// pizza.AddIngredient(new Mozzarella());
// pizza.AddIngredient(new Cheddar());
// pizza.AddIngredient(new TomatoSauce());
//
// Console.WriteLine(pizza);

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