namespace UltimateCourse;

public class Cheddar : Ingredient
{
    public Cheddar(int priceIfExtraTopping, int agedForMonth) : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonth;
    }

    public override string Name => $"{base.Name}, more specifially, a Cheddar cheese for {AgedForMonths} months";

    public override void Prepare() =>
        Console.WriteLine("Grate and sprinkle over the pizza.");

    public int AgedForMonths { get; }
}