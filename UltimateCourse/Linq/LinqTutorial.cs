namespace UltimateCourse.Linq;

public class LinqTutorial
{
    public static void Run()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5, 6, 13 };
        Console.WriteLine(numbers.Contains(7));

        var animals = new List<string> { "lion", "tiger", "show leopard" };
        Console.WriteLine(animals.Contains("tiger"));
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