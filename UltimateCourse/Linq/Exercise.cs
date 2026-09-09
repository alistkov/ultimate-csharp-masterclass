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
}