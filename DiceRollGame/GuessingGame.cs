namespace DiceRollGame;

public class GuessingGame(Dice dice)
{
    private const int InitialTries = 3;

    public bool Play()
    {
        var diceRollResult = dice.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries");
        var triesLeft = InitialTries;
        while (triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter a number: ");

            if (guess == diceRollResult)
            {
                return true;
            }

            Console.WriteLine("Wrong number");
            --triesLeft;
        }

        return false;
    }
}