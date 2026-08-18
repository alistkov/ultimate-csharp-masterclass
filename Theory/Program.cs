var words = new List<string>
{
    "one",
    "two",
    "three"
};

Console.WriteLine($"Count of elements is {words.Count}");

words.Add("hello");

Console.WriteLine($"Count of elements is {words.Count}");

for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}

Console.WriteLine("-----------------");

words.Remove("two");

words.RemoveAt(2);

foreach (var word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine("-----------------");
var moreWords = new List<string> { "eins", "zwei", "drei" };
words.AddRange(moreWords);

foreach (var word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine("-----------------");
Console.WriteLine($"Index of eins is {words.IndexOf("eins")}");
Console.WriteLine($"Index of seven is {words.IndexOf("seven")}");
Console.WriteLine("-----------------");
words.Clear();
Console.WriteLine($"Count of elements is {words.Count}");