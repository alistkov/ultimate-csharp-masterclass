namespace UltimateCourse;

public static class NumericTypesDescriber
{
    public static string? Describe(object someObject)
    {
        //your code goes here
        return someObject switch
        {
            int => $"Int of value {someObject}",
            double => $"Double of value {someObject}",
            decimal => $"Decimal of value {someObject}",
            _ => null
        };
    }
}