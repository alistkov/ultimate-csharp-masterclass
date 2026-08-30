namespace UltimateCourse;

public class Exercise
{
    public Func<string, int> GetLength = word => word.Length;
    public Func<int> GetRandomNumberBetween1And10 = () => new Random().Next(1, 11);
}