namespace UltimateCourse;

public class Pizza : Bakeable
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

    public override string GetInstruction()
    {
        throw new NotImplementedException();
    }
}