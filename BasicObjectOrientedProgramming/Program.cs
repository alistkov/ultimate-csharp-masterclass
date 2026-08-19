using BasicObjectOrientedProgramming;

var calculator = new ShapeMeasurementsCalculator();

var rectangle1 = new Rectangle(5, 10);
Console.WriteLine($"Rectangle width is {rectangle1.Width}");
Console.WriteLine($"Rectangle height is {rectangle1.Height}");
Console.WriteLine($"Rectangle circumference {calculator.CalculateRectangleCircumference(rectangle1)}");
Console.WriteLine($"Rectangle area {calculator.CalculateRectangleArea(rectangle1)}");

var rectangle2 = new Rectangle(40, 1);
Console.WriteLine($"Rectangle width is {rectangle2.Width}");
Console.WriteLine($"Rectangle height is {rectangle2.Height}");
Console.WriteLine($"Rectangle circumference {calculator.CalculateRectangleCircumference(rectangle2)}");
Console.WriteLine($"Rectangle area {calculator.CalculateRectangleArea(rectangle2)}");

