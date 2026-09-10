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

// void AddOneToPersonAge(Person person)
// {
//     ++person.Age;
// }

Person AddOneToPersonAge(Person person)
{
    return new Person
    {
        Name = person.Name,
        Age = person.Age + 1
    };
}

struct Person
{
    public required string Name { get; init; }
    public required int Age { get; init; }
}