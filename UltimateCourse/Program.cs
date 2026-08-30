var numbers = new[] { 1, 4, 7, 19, 2 };

Console.WriteLine($"IsAnyLargerThan10? {IsAny(numbers, IsLargerThan10)}");
Console.WriteLine($"IsAnyEven? {IsAny(numbers, IsEven)}");

bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number))
            return true;
    }

    return false;
}

bool IsLargerThan10(int number) => number > 10;
bool IsEven(int number) => number % 2 == 10;