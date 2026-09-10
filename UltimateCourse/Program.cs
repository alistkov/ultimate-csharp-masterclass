using UltimateCourse.UnderTheHood;

var date = new DateTime(2024, 8, 14);
var date2 = new DateTime(2024, 7, 21);
var date3 = new DateTime(2025, 2, 14);

Console.WriteLine($"date before: {date}");
Exercise.FastForwardToSummer(ref date);
Console.WriteLine($"date after: {date}");

Console.WriteLine($"date3 before: {date3}");
Exercise.FastForwardToSummer(ref date3);
Console.WriteLine($"date3 after: {date3}");
