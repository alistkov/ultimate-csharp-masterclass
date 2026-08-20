namespace DiceRollGame;

public class Dice
{
    private readonly Random _random;
    private readonly int _sidesCount;

    public Dice(int sidesCount)
    {
        _random = new Random();
        _sidesCount = sidesCount;
    }

    public int Roll() => _random.Next(1, _sidesCount + 1);

    public void Describe() =>
        Console.WriteLine($"This is a dise with {_sidesCount}");
}