var numbers = new List<int> { 10, 12, -100, 55, 17, 22 };

var filteringStrategySelector = new FilteringStrategySelector();

Console.WriteLine("Select filter:");
Console.WriteLine(string.Join(Environment.NewLine, filteringStrategySelector.FilteringStrategiesName));

var userInput = Console.ReadLine();

var filteringStrategy = filteringStrategySelector.Select(userInput);
var result = new Filter().FilterBy(filteringStrategy, numbers);

Print(result);

void Print(IEnumerable<int> numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

public class Filter
{
    public IEnumerable<T> FilterBy<T>(Func<T, bool> predicate, IEnumerable<T> data)
    {
        var result = new List<T>();

        foreach (var element in data)
        {
            if (predicate(element))
            {
                result.Add(element);
            }
        }

        return result;
    }
}

public class FilteringStrategySelector
{
    private readonly Dictionary<string, Func<int, bool>> _filteringStrategies = new Dictionary<string, Func<int, bool>>
    {
        ["Even"] = (number) => number % 2 == 0,
        ["Odd"] = (number) => number % 2 != 0,
        ["Positive"] = (number) => number > 0,
        ["Negative"] = (number) => number < 0,
    };

    public IEnumerable<string> FilteringStrategiesName => _filteringStrategies.Keys;

    public Func<int, bool> Select(string filterType)
    {
        if (!_filteringStrategies.ContainsKey(filterType))
        {
            throw new NotSupportedException($"{filterType} is not a valid filter");
        }

        return _filteringStrategies[filterType];
    }
}