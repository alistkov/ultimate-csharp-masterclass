Console.Write("Enter a number: ");
var input = Console.ReadLine();

try
{
    var number = ParseStringToInt(input);
    Console.WriteLine($"String successfully parsed, the result is {number}");
}
catch (Exception ex)
{
    Console.WriteLine("An exception was thrown " + ex.Message);
}
finally
{
    Console.WriteLine("Finally block is being executed");
}

int ParseStringToInt(string input)
{
    return int.Parse(input);
}