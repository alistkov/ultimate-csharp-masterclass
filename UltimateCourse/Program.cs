using UltimateCourse.Linq;

// LinqTutorial.Run();

var numbers = new List<List<int>>
{
    new List<int> { 1, 2, 5, -1 },
    new List<int> { 0, 4, 4, 6 },
    new List<int> { 9, 0 }
};

Console.WriteLine(Exercise.CountListsContainingZeroLongerThan(3, numbers));