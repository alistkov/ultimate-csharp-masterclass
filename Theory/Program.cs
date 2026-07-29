string BuildHelloString()
{
    char[] letters = new[] { 'h', 'e', 'l', 'l', 'o' };
    var result = "";
    for(int i = 0; i < letters.Length; ++i)
    {
        //your code goes here
        result = $"{result}{letters[i]}";
    }
    return result;
}

Console.WriteLine(BuildHelloString());

bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
{
    //your code goes here
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i] == wordToBeChecked)
        {
            return true;
        }
    }

    return false;
}

Console.WriteLine(IsWordPresentInCollection(["one", "two", "three"], "hello"));
Console.WriteLine(IsWordPresentInCollection(["one", "two", "three"], "two"));