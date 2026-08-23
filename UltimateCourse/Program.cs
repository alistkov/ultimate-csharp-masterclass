using System.Text.Json;
using UltimateCourse;

var person = new Person
{
    FirstName = "John",
    LastName = "Doe",
    YearOfBirth = 1980
};
var asJson = JsonSerializer.Serialize(person);
Console.WriteLine($"As JSON: {asJson}");

var personJson = 
    "{\"FirstName\":\"John\",\"LastName\":\"Doe\",\"YearOfBirth\":1980}";

var personFromJson = JsonSerializer.Deserialize<Person>(personJson);

Console.ReadKey();