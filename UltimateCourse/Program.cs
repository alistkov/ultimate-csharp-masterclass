var numbers = new List<int> { 10, 12, -100, 55, 17, 22 };

Console.WriteLine(@"Select filter:
Even
Odd
Positive");

var userInput = Console.ReadLine();

var result = new NumbersFilter().FilterBy(userInput, numbers);

Print(result);

void Print(IEnumerable<int> numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

public class NumbersFilter
{
    public List<int> FilterBy(string filterType, List<int> numbers)
    {
        return filterType switch
        {
            "Even" => SelectEven(numbers),
            "Odd" => SelectOdd(numbers),
            "Positive" => SelectPositive(numbers),
            _ => throw new NotSupportedException($"{filterType} is not a valid filter")
        };
    }
    
    private List<int> SelectEven(List<int> numbers)
    {
        var result = new List<int>();

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                result.Add(number);
            }
        }

        return result;
    }

    private List<int> SelectOdd(List<int> numbers)
    {
        var result = new List<int>();

        foreach (var number in numbers)
        {
            if (number % 2 != 0)
            {
                result.Add(number);
            }
        }

        return result;
    }


    private List<int> SelectPositive(List<int> numbers)
    {
        var result = new List<int>();

        foreach (var number in numbers)
        {
            if (number > 0)
            {
                result.Add(number);
            }
        }

        return result;
    }
}
