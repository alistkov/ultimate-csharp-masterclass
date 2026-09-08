namespace UltimateCourse.OOP;

public sealed class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Mozzarella";

    public override void Prepare() =>
        Console.WriteLine("Slice tinly and place on top of the pizza.");

    public bool IsLight { get; }
}