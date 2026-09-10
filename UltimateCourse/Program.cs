var number = 5;

AddOneToNumber(ref number);
Console.WriteLine($"number now is {number}");

var otherNumber = 19;

MethodWithOutParameter(out otherNumber);
Console.WriteLine($"other number is {otherNumber}");

void MethodWithOutParameter(out int number)
{
    number = 10;
}

void AddOneToNumber(ref int number)
{
    ++number;
}