var cheddar = new Cheddar();
Console.WriteLine(cheddar);

var pizza = new Pizza();
pizza.AddIngredient(new Mozzarella());
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());

Console.WriteLine(pizza);

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

public class Cheese : Ingredient {}

public class ItalianFood {}

public class Cheddar : Cheese
{
    public override string Name => "Cheddar cheese";

    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
    public override string Name => "Tomato sauce";

    public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Cheese
{
    public override string Name => "Mozzarella";

    public bool IsLight { get; }
}