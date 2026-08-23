namespace UltimateCourse;

public abstract class Ingredient(int priceIfExtraTopping)
{
    public int PriceIfExtraTopping { get; } = priceIfExtraTopping;
    public virtual string Name { get; } = "Some ingredient";

    public abstract void Prepare();

    public int PublicField;

    public string PublicMethods() =>
        "This method is PUBLIC in the Ingredient class";

    private string PrivateMethods() =>
        "This method is PRIVATE in the Ingredient class";

    protected string ProtectedMethods() =>
        "This method is PROTECTED in the Ingredient class";

    public override string ToString() => Name;
}