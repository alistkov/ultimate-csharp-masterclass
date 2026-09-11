string userInput = Console.ReadLine();
if (userInput == "Print person")
{
    Person person = new Person { Name = "John Doe", Age = 35 };
    Console.WriteLine($"{person.Name} is {person.Age} years old");
}

GC.Collect();

Console.ReadKey();


class Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}