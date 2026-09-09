namespace UltimateCourse.Linq;

public class LinqTutorial
{
    public static void Run()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5, 6, 13 };
        var isAnyLargerThan10 = numbers.Any(number => number > 10);
        Console.WriteLine(isAnyLargerThan10);
    }

    public static bool IsAnyWordUpperCase(IEnumerable<string> words)
    {
        foreach (var word in words)
        {
            var areAllUpperCase = true;
            
            foreach (var letter in word)
            {
                if (char.IsLower(letter))
                {
                    areAllUpperCase = false;
                }
            }

            if (areAllUpperCase)
            {
                return true;
            }
        }

        return false;
    }

    public static bool IsAnyWordUpperCaseLinq(IEnumerable<string> words)
    {
        return words.Any(word => 
            word.All(letter => 
                char.IsUpper(letter)));
    }
}