using BasicObjectOrientedProgramming;

var rectangle1 = new Rectangle(5, 10);

Console.WriteLine($"Rectangle width is {rectangle1.Width}");
Console.WriteLine($"Rectangle height is {rectangle1.Height}");
Console.WriteLine($"Rectangle circumference {rectangle1.CalculateCircumference()}");
Console.WriteLine($"Rectangle area {rectangle1.CalculateArea()}");

var rectangle2 = new Rectangle(40, 1);

Console.WriteLine($"Rectangle width is {rectangle2.Width}");
Console.WriteLine($"Rectangle height is {rectangle2.Height}");
Console.WriteLine($"Rectangle circumference {rectangle2.CalculateCircumference()}");
Console.WriteLine($"Rectangle area {rectangle2.CalculateArea()}");

