using UltimateCourse;

// Console.WriteLine("Variable of type Cheddar");
// var cheddar = new Cheddar();
// Console.WriteLine(cheddar.Name);
//
// Console.WriteLine("Variable of type Ingredient");
// Ingredient ingredient = new Cheddar();
// Console.WriteLine(ingredient.Name);

var words = new List<string> { "bobcat", "wolverine", "grizzly" };
var exercise = new Exercise();
var processedWords = exercise.ProcessAll(words);
foreach (var processedWord in processedWords)
{
    Console.WriteLine(processedWord);
}


// var ingredients = new List<Ingredient>
// {
//     new Cheddar(),
//     new TomatoSauce(),
//     new Mozzarella()
// };
//
// foreach (var ingredient in ingredients)
// {
//     Console.WriteLine(ingredient.Name);
// }

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
    public virtual string Name { get; } = "Some ingredient";

    public int PublicField;

    public string PublicMethods() =>
        "This method is PUBLIC in the Ingredient class";

    private string PrivateMethods() =>
        "This method is PRIVATE in the Ingredient class";

    protected string ProtectedMethods() =>
        "This method is PROTECTED in the Ingredient class";
}

public class Cheddar : Ingredient
{
    public override string Name => "Cheddar cheese";

    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
    public override string Name => "Tomato sauce";

    public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public override string Name => "Mozzarella";

    public bool IsLight { get; }
}