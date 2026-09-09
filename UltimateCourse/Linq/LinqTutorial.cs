namespace UltimateCourse.Linq;

public class LinqTutorial
{
    public static void Run()
    {
        var words = new List<string> { "a", "bb", "ccc", "dddd" };
        var shortWords = words.Where(word => word.Length < 3).ToList();
        
        Console.WriteLine("First iteration");
        foreach (var word in shortWords)
        {
            Console.WriteLine(word);
        }
        words.Add("e");
        Console.WriteLine("Second iteration");
        foreach (var word in shortWords)
        {
            Console.WriteLine(word);
        }
        
        var wordsLongerThan2 = words.Where(word => word.Length > 2);

        var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
        var oddNumbers = numbers.Where(number => number % 2 != 0);
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