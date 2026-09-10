using UltimateCourse.Linq;

// LinqTutorial.Run();

var timeSpans = new List<TimeSpan>
{
    new TimeSpan(0, 0, 0, 0, 100),
    new TimeSpan(0, 0, 0, 0, 50),
    new TimeSpan(0, 0, 0, 0, 30),
};

var t = Exercise.CalculateAverageDurationInMilliseconds(timeSpans);
Console.WriteLine(t);
