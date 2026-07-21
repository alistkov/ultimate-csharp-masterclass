Console.WriteLine("Provide a number");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);
Console.WriteLine(number);

// Console.WriteLine("Hello!");
// Console.WriteLine("What do you want to do?");
// Console.WriteLine("[S]ee all TODOs");
// Console.WriteLine("[A]dd a TODO");
// Console.WriteLine("[R]emove a TODO");
// Console.WriteLine("[E]xit");
//
// var userChoice = Console.ReadLine();
//
// switch (userChoice)
// {
//     case "S":
//         PrintSelectedOption("See all TODOs");
//         break;
//     case "A":
//         PrintSelectedOption("Add a TODO");
//         break;
//     case "R":
//         PrintSelectedOption("Remove a TODO");
//         break;
//     case "E":
//         PrintSelectedOption("Exit");
//         break;
// }
//
// void PrintSelectedOption(string selectedOption)
// {
//     Console.WriteLine($"Selected option: {selectedOption}");
// }
//
// Console.ReadKey();