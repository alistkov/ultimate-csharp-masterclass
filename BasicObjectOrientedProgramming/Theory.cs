namespace BasicObjectOrientedProgramming;

public static class Theory
{
    public static void Run()
    {
        var internationalPizzaDay = new DateTime(2026, 2, 9);

        Console.WriteLine($"Year is {internationalPizzaDay.Year}");
        Console.WriteLine($"Month is {internationalPizzaDay.Month}");
        Console.WriteLine($"Day is {internationalPizzaDay.Day}");
        Console.WriteLine($"Day of the week is {internationalPizzaDay.DayOfWeek}");

        var nextYearInternationalPizzaDay = internationalPizzaDay.AddYears(1);
        Console.WriteLine($"Day of the week is {nextYearInternationalPizzaDay.DayOfWeek}");
    }
}

class Rectangle
{
    private const int NumbersOfSides = 4;
    public readonly int Width;
    private int _height;

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefaultValue(width, nameof(Width));
        _height = GetLengthOrDefaultValue(height, nameof(_height));
    }

    public int GetHeight() => _height;

    public void SetHeight(int height)
    {
        if (height > 0)
        {
            _height = height;
        }
    }

    private int GetLengthOrDefaultValue(int length, string name)
    {
        const int defaultValue = 1;
        if (length > 0) return length;
        Console.WriteLine($"{name} must be positive number");
        return defaultValue;

    }

    public int CalculateCircumference() => 2 * Width + 2 * _height;

    public int CalculateArea() => Width * _height;
}

class ShapeMeasurementsCalculator
{
    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.GetHeight();

    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.GetHeight();
}