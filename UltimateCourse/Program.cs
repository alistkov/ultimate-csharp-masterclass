using System.Collections;

int number = 5;
var person = new Person { Name = "Sam", Age = 22 };
object boxedNumber = number;
short unboxedNumber = (short)boxedNumber;

var numbers1 = new List<int> { 1, 2, 3, 4, 5 };
var numbers2 = new ArrayList { 1, 2, 3, 4, 5 };
var numbers3 = new List<IComparable<int>> { 1, 2, 3, 4, 5 };

var variousObjects = new List<object>
{
    1, 3L, 1.5m, new DateTime(2027, 1, 1), "hello", new Person { Name = "John Doe", Age = 35 }, true
};

foreach (var someObject in variousObjects)
{
    Console.WriteLine(someObject);
    Console.WriteLine(someObject.GetType().Name);
}

Console.ReadKey();


class Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}