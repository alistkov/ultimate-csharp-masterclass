using UltimateCourse.UnderTheHood;

const string path =
    "/Users/alistkov/Code/courses/csharp/ultimate-course/UltimateCourse/UltimateCourse/UnderTheHood/sampleData.csv";
    
var data = new CsvReader().Read(path);

Console.ReadKey();