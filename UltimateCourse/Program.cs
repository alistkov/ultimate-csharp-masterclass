using UltimateCourse.Linq;

var wordsNoUpperCase = new string[]
{
    "quick", "brown", "rain"
};

var wordsWithUpperCase = new string[]
{
    "quick", "brown", "rain", "PAIN"
};

Console.WriteLine(LinqTutorial.IsAnyWordUpperCase(wordsNoUpperCase));
Console.WriteLine(LinqTutorial.IsAnyWordUpperCase(wordsWithUpperCase));
Console.WriteLine(LinqTutorial.IsAnyWordUpperCaseLinq(wordsNoUpperCase));
Console.WriteLine(LinqTutorial.IsAnyWordUpperCaseLinq(wordsWithUpperCase));
