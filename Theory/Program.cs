// Console.WriteLine("Enter a number");
// var userInput = Console.ReadLine();
// // int asNumber = int.Parse(userInput);
//
// bool isParsingSuccessful = int.TryParse(userInput, out int number);
//
// if (isParsingSuccessful)
// {
//     Console.WriteLine($"Parsing worked, the number is {number}");
// }
// else
// {
//     Console.WriteLine("Parsing was not successful");
// }

bool isParsingSuccessful;

do
{
    Console.WriteLine("Enter a number");
    var userInput = Console.ReadLine();
    isParsingSuccessful = int.TryParse(userInput, out int number);
    Console.WriteLine(isParsingSuccessful ? $"Parsing worked, the number is {number}" : "Parsing was not successful");
} while (!isParsingSuccessful);
