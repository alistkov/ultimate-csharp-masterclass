var internationalPizzaDay = new DateTime(2026, 2, 9);

Console.WriteLine($"Year is {internationalPizzaDay.Year}");
Console.WriteLine($"Month is {internationalPizzaDay.Month}");
Console.WriteLine($"Day is {internationalPizzaDay.Day}");
Console.WriteLine($"Day of the week is {internationalPizzaDay.DayOfWeek}");

var nextYearInternationalPizzaDay = internationalPizzaDay.AddYears(1);
Console.WriteLine($"Day of the week is {nextYearInternationalPizzaDay.DayOfWeek}");