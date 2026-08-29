// var point = CreateCollectionOfRandomLength<Point>(100);
// var numbers = CreateCollectionOfRandomLength<int>(100);
var dates = CreateCollectionOfRandomLength<DateTime>(100);

Console.ReadKey();

IEnumerable<T> CreateCollectionOfRandomLength<T>(int maxLength) where T: new()
{
    var length = new Random().Next(maxLength + 1);
    var result = new List<T>();

    for (int i = 0; i < length; i++)
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