var numbers = new List<int> { 5, 3, 2, 8, 16, 7 };
// var minAndMax = GetMinAndMax(numbers);
// Console.WriteLine($"Min value {minAndMax.Int1}");
// Console.WriteLine($"Max value {minAndMax.Int2}");

var minAndMax = CalculateMaxAndMin(numbers);
Console.WriteLine($"Min value {minAndMax.Min}");
Console.WriteLine($"Max value {minAndMax.Max}");

(int Min, int Max) CalculateMaxAndMin(IEnumerable<int> input)
{
    if (!input.Any())
    {
        throw new InvalidOperationException($"The input cannot be empty.");
    }

    var max = input.First();
    var min = input.First();

    foreach (var i in input)
    {
        if (i > max)
        {
            max = i;
        }
        if (i < min)
        {
            min = i;
        }
    }


    return (min, max);
}

TwoInts GetMinAndMax(IEnumerable<int> input)
{
    if (!input.Any())
    {
        throw new InvalidOperationException($"The input cannot be empty.");
    }

    var max = input.First();
    var min = input.First();

    foreach (var i in input)
    {
        if (i > max)
        {
            max = i;
        }
        if (i < min)
        {
            min = i;
        }
    }


    return new TwoInts(min, max);
}

public class TwoInts
{
    public TwoInts(int int1, int int2)
    {
        Int1 = int1;
        Int2 = int2;
    }

    public int Int1 { get; }
    public int Int2 { get; }
}