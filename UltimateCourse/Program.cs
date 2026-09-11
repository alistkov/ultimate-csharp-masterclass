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