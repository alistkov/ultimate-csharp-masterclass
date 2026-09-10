namespace UltimateCourse.Linq;

public class Exercise
{
    public static bool IsAnyWordWhiteSpace(List<string> words) 
    {
        //your code goes here
        return words.Any(word =>
            word.All(letter => 
                char.IsWhiteSpace(letter)));
    }
    
    public static int CountListsContainingZeroLongerThan(
        int length,
        List<List<int>> listsOfNumbers)
    {
        //your code goes here
        return listsOfNumbers
            .Count(list => 
                list.Count() > length && list.Contains(0));
    }
    
    public static string FindShortestWord(List<string> words)
    {
        //your code goes here
        return words
            .OrderBy(word => word.Length)
            .First();
    }
    
    public static IEnumerable<DateTime> GetFridaysOfYear(int year, IEnumerable<DateTime> dates) 
    {
        //your code goes here
        var r = dates
            .Distinct()
            .Where((date) => date.Year == year && date.DayOfWeek == DayOfWeek.Friday);

        return r;
    }
    
    public static double CalculateAverageDurationInMilliseconds(IEnumerable<TimeSpan> timeSpans)
    {
        //your code goes here
        return timeSpans
            .Select(timeSpan => timeSpan.TotalMicroseconds)
            .Average() / 1000;
    }
}