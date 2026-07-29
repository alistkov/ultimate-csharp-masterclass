char ConvertPointsToGrade(int points)
{
    return points switch
    {
        10 or 9 => 'A',
        8 or 7 or 6 => 'B',
        5 or 4 or 3 => 'C',
        2 or 1 => 'D',
        0 => 'E',
        _ => '!'
    };
}

Console.WriteLine(ConvertPointsToGrade(10));
Console.WriteLine(ConvertPointsToGrade(3));
Console.WriteLine(ConvertPointsToGrade(7));
Console.WriteLine(ConvertPointsToGrade(110));
