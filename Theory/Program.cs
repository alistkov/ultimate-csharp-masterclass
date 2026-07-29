int FindMax(int[,] numbers)
{
    //your code goes here
    var a = numbers.GetLength(0);
    var b = numbers.GetLength(1);
    
    if (a == 0 || b == 0)
    {
        return -1;
    }
    
    var maxValue = numbers[0, 0];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            if (numbers[i, j] > maxValue)
            {
                maxValue = numbers[i, j];
            }
        }
    }

    return maxValue;
}

var array1 = new int[,]
{
    {3, 5},
    {-1, 12},
    {4, 0}
};

var array2 = new int[0, 3];
var array3 = new int[1, 0];

Console.WriteLine(FindMax(array1));
Console.WriteLine(FindMax(array2));
Console.WriteLine(FindMax(array3));