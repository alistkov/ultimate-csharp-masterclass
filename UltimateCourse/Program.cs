var number = 5;
var person = new Person { Name = "John Doe", Age = 35 };

AddOneToNumber(number);
AddOneToPersonAge(person);

Console.WriteLine($"number now is {number}");
Console.WriteLine($"person age now is {person.Age}");

void AddOneToNumber(int number)
{
    ++number;
}

void AddOneToPersonAge(Person person)
{
    ++person.Age;
}

class Person
{
    public required string Name { get; set; }
    public required int Age { get; set; }
}