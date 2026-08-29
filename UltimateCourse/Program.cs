var decimals = new List<decimal> { 1.1m, 0.5m, 22.4m, 12.9m };
var ints = decimals.ConvertTo<decimal, int>();

Console.ReadKey();

public static class ListExtensions
{
    public static void AddToFront<T>(this List<T> list, T item)
    {
        list.Insert(0, item);
    }

    public static List<TTarget> ConvertTo<TSource, TTarget>(this List<TSource> decimals)
    {
        var result = new List<TTarget>();

        foreach (var item in decimals)
        {
            TTarget itemAfterCasting = (TTarget)Convert.ChangeType(item, typeof(TTarget))!;
            result.Add(itemAfterCasting);
        }

        return result;
    }
}