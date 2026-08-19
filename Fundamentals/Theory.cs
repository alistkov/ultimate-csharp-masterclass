namespace Fundamentals;

public class Theory
{
    public static void run()
    {
        bool isParsingSuccessful;

        do
        {
            Console.WriteLine("Enter a number");
            var userInput = Console.ReadLine();
            isParsingSuccessful = int.TryParse(userInput, out int number);
            Console.WriteLine(isParsingSuccessful ? $"Parsing worked, the number is {number}" : "Parsing was not successful");
        } while (!isParsingSuccessful);
    }
}