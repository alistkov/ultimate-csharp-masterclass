namespace UltimateCourse.UnderTheHood;

public class Exercise
{
    public static void FastForwardToSummer(ref DateTime date)
    {
        //your code goes here
        var firstDayOfSummer = new DateTime(date.Year, 6, 1);

        if (date < firstDayOfSummer)
        {
            date = firstDayOfSummer;
        }
    }
}