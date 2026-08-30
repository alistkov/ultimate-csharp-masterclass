var numbers = new List<int> { 2, 4, 1, 12, 5, 0 };
numbers.Sort();

var words = new List<string> { "dd", "aa", "cc", "bb" };
words.Sort();

var people = new List<Person>
{
    new Person { Name = "John", YearOfBirth = 1980 },
    new Person { Name = "Sam", YearOfBirth = 1915 },
    new Person { Name = "Bob", YearOfBirth = 2011 }
};

people.Sort();

Console.ReadKey();

public class Person : IComparable<Person>
{
    public string Name { get; init; }
    public int YearOfBirth { get; init; }
    public int CompareTo(Person other)
    {
        if (YearOfBirth < other.YearOfBirth)
        {
            return 1;
        }

        if (YearOfBirth > other.YearOfBirth)
        {
            return -1;
        }

        return 0;
    }
}