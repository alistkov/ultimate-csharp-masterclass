using UltimateCourse;
using UltimateCourse.Extensions;

var multiLineString = @"aaa
bbb
ccc
ddd";

Console.WriteLine(multiLineString.CountLines());

int CountLines(string input) =>
    input.Split(Environment.NewLine).Length;

Console.WriteLine(multiLineString);

Console.WriteLine($"Next season after spring is {Season.Spring.Next()}");
Console.WriteLine($"Next season after summer is {Season.Summer.Next()}");
Console.WriteLine($"Next season after autumn is {Season.Autumn.Next()}");
Console.WriteLine($"Next season after winter is {Season.Winter.Next()}");

Console.WriteLine(new List<int>{ 1, 5, 10, 8, 12, 4, 5 }.TakeEverySecond());
Console.WriteLine(new List<int>{ 1, 5, 10, 8, 12, 4, 5, 6 }.TakeEverySecond());
Console.WriteLine(new List<int>{ 1 }.TakeEverySecond());
Console.WriteLine(new List<int>{}.TakeEverySecond());

