namespace UltimateCourse.OOP;

public class NumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        var sum = 0;

        foreach (var number in numbers)
        {
            if (ShallBeAdded(number))
            {
                sum += number;
            }
        }

        return sum;
    }

    protected virtual bool ShallBeAdded(int number)
    {
        return true;
    }
}

public class PositiveNumbersSumCalculator : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}