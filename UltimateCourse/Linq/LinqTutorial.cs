namespace UltimateCourse.Linq;

public class LinqTutorial
{
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