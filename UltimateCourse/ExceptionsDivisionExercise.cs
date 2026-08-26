namespace UltimateCourse;

public class ExceptionsDivisionExercise
{
    public static int GetMaxValue(List<int> numbers)
    {
        try
        {
            return numbers.Max();
        }
        catch (ArgumentNullException ex)
        {
            throw new ArgumentNullException("The numbers list cannot be null.", ex);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("The collection is empty!");
            throw;
        }
    }
}