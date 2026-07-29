bool IsAnyWordLongerThan(int length, string[] words)
{
    //your code goes here
    foreach (var word in words)
    {
        if (word.Length > length)
            return true;
    }

    return false;
}

Console.WriteLine(IsAnyWordLongerThan(4, ["aaa", "bbbb", "ccccc"]));
Console.WriteLine(IsAnyWordLongerThan(5, ["aaa", "bbbb", "ccccc"]));
Console.WriteLine(IsAnyWordLongerThan(4, []));