var number = 5;
var anotherNumber = number;
anotherNumber++;

var person = new Person { Name = "John Doe", Age = 35 };
var copyPerson = person;
copyPerson.Name = "Sam Smith";

Console.WriteLine($"number is {number}");
Console.WriteLine($"another number is {anotherNumber}");
Console.WriteLine("---------------------");
Console.WriteLine($"Person name {person.Name}");
Console.WriteLine($"Copy person name {copyPerson.Name}");

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}