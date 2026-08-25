Console.Write("Enter a number: ");
var userInput = Console.ReadLine();

try
{
    var number = ParseStringToInt(userInput);
    var result = 10 / number;
    // Console.WriteLine($"String successfully parsed, the result is {number}");
    Console.WriteLine($"10 / {number} is {result}");
}
catch (FormatException ex)
{
    Console.WriteLine("Wrong format. Input string is not parsable to int. Exception message: " + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Diviision by zero is an invalid operation. Exception message: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Unexpected error occurred. Exception message: " + ex.Message);
}
finally
{
    Console.WriteLine("Finally block is being executed");
}

int ParseStringToInt(string input)
{
    return int.Parse(input);
}