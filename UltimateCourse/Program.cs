// var point = CreateCollectionOfRandomLength<Point>(100);
// var numbers = CreateCollectionOfRandomLength<int>(100);

using System.Diagnostics;

var stopWatch = Stopwatch.StartNew();
var dates = CreateCollectionOfRandomLength<DateTime>(0);
stopWatch.Stop();

Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds} ms");

Console.ReadKey();

IEnumerable<T> CreateCollectionOfRandomLength<T>(int maxLength) where T: new()
{
    var length = 100000000; // new Random().Next(maxLength + 1);
    var result = new List<T>(length);

    for (var i = 0; i < length; i++)
    {
        result.Add(new T());
    }

    return result;
}

public class Point
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    public int X { get; }
    public int Y { get; }
}