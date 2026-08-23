namespace UltimateCourse.Extensions;

public static class ListExtensions
{
    public static List<int> TakeEverySecond(this List<int> numbers)
    {
        var result = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (i % 2 == 0)
                result.Add(numbers[i]);
        }

        return result;
    }
}