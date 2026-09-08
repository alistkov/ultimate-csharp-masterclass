namespace UltimateCourse.OOP;

public class Pizza : IBakeable
{
    public int number;
    public DateTime date;
    public Ingredient ingredient;

    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public override string ToString() =>
        $"This is a pizza with {string.Join(", ", _ingredients)} ingredients";

    public string GetInstruction() => "Bake at 250 degrees Celsius for 10 minutes, ideally on a stone";
}