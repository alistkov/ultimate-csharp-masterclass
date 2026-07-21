Console.WriteLine("Hello!");
Console.Write("Enter the first number: ");
var first = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
var second = int.Parse(Console.ReadLine());

Console.WriteLine("What you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

var operation = Console.ReadLine();
Console.WriteLine();

if (string.Equals(operation, "A", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"{first} + {second} = {first + second}");
}
else if (string.Equals(operation, "S", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"{first} - {second} = {first - second}");
}
else if (string.Equals(operation, "M", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"{first} * {second} = {first * second}");
}