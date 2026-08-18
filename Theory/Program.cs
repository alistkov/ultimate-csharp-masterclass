List<string> GetOnlyUpperCaseWords(List<string> words)
{
    //your code goes here

    var result = new List<string>();

    foreach (var word in words)
    {
        if (result.Contains(word))
        {
            continue;
        }
        var isAllLettersUppercase = true;

        foreach (var letter in word)
        {
            if (!char.IsUpper(letter))
            {
                isAllLettersUppercase = false;
                break;
            }
        }

        if (isAllLettersUppercase)
        {
            result.Add(word);
        }
    }
    return result;
}

var one = GetOnlyUpperCaseWords(new List<string>{"one", "TWO", "THREE", "four"});
var two = GetOnlyUpperCaseWords(new List<string>{"one", "TWO", "THREE", "four", "TWO"});
var three = GetOnlyUpperCaseWords(new List<string>{"one", "TWO123", "THREE!&^", "four"});

foreach (var word in one)
{
    Console.WriteLine(word);
}
Console.WriteLine("-------------");
foreach (var word in two)
{
    Console.WriteLine(word);
}
Console.WriteLine("-------------");
foreach (var word in three)
{
    Console.WriteLine(word);
}
Console.WriteLine("-------------");