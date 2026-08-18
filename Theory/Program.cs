var numbers = new[] { 10, -8, 2, 12, -17 };

var answer = GetOnyPositive(numbers, out int nonPositiveCount);

foreach (var i in answer)
{
    Console.WriteLine(i);
}

Console.WriteLine($"Count of non positive numbers: {nonPositiveCount}");

Console.ReadKey();

List<int> GetOnyPositive(int[] numbers, out int countOfNonPositive)
{
    var result = new List<int>();
    countOfNonPositive = 0;

    foreach (var number in numbers)
    {
        if (number > 0)
        {
            result.Add(number);
        }
        else
        {
            countOfNonPositive += 1;
        }
    }

    return result;
}
