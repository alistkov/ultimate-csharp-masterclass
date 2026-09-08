namespace UltimateCourse.OOP;

public class TomatoSauce(int priceIfExtraTopping) : Ingredient(priceIfExtraTopping)
{
    public override string Name => "Tomato sauce";

    public sealed override void Prepare() =>
        Console.WriteLine("Cook tomatoes with basil, garlic and salt. Spread on pizza.");

    public int TomatoesIn100Grams { get; }
}
