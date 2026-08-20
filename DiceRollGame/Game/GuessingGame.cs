using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game;

public class GuessingGame(Dice dice)
{
    private const int InitialTries = 3;

    public GameResult Play()
    {
        var diceRollResult = dice.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries");
        var triesLeft = InitialTries;
        while (triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter a number: ");

            if (guess == diceRollResult)
            {
                return GameResult.Victory;
            }

            Console.WriteLine("Wrong number");
            --triesLeft;
        }

        return GameResult.Loss;
    }

    public static void PrintResult(GameResult gameResult)
    {
        var message = gameResult == GameResult.Victory
            ? "You won!"
            : "You lose :(";
        
        Console.WriteLine(message);
    }
}