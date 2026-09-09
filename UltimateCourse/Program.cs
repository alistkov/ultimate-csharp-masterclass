using UltimateCourse.Linq;

// LinqTutorial.Run();

var dates = new List<DateTime>
{
    new DateTime(2023, 3, 24),
    new DateTime(2023, 3, 25),
    new DateTime(2023, 3, 24),
    new DateTime(2023, 3, 31),
    new DateTime(2023, 3, 8),
};

Console.WriteLine(Exercise.GetFridaysOfYear(2023, dates));
// 3/24/2023 (Friday)
// 3/25/2023 (Saturday)
// 3/24/2023 (Friday)
// 3/31/2023 (Friday)
// 3/8/2024 (Friday)