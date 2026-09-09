using UltimateCourse.Linq;

LinqTutorial.Run();


var words1 = new List<string>{"hello", "There    "};
var words2 = new List<string>{"hello", "      "};

Console.WriteLine(Exercise.IsAnyWordWhiteSpace(words1));
Console.WriteLine(Exercise.IsAnyWordWhiteSpace(words2));