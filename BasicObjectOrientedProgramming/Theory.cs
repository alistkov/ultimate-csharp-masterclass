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
    private int _width;
    public static int CountOfInstances { get; private set; }
    private static DateTime _firstUsed;

    public int Width
    {
        get { return _width; }

        private set
        {
            if (value > 10)
            {
                _width = value;
            }
        }
    }

    private int _height;
    public int Height { get; }

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefaultValue(width, nameof(Width));
        Height = GetLengthOrDefaultValue(height, nameof(Height));
        ++CountOfInstances;
    }

    static Rectangle()
    {
        _firstUsed = DateTime.Now;
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

    public int CalculateCircumference() => 2 * Width + 2 * Height;

    public int CalculateArea() => Width * Height;

    public string Description => $"Rectangle width {Width} and height {Height}";
}

class ShapeMeasurementsCalculator
{
    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.GetHeight();

    public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.GetHeight();
}

static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;

    public static double PI = 3.14;
}