using UltimateCourse.UnderTheHood;

const string filePath = "file.txt";

using (var writer = new FileWriter(filePath))
{
    writer.Write("some text");
    writer.Write("some other text");
}
// writer.Dispose();

// from C# 8
using var reader = new SpecificLineFromTextFileReader(filePath);
var third = reader.ReadLineNumber(3);
var fourth = reader.ReadLineNumber(4);
// reader.Dispose();

Console.WriteLine($"Third line is {third}");
Console.WriteLine($"Fourth line is {fourth}");

Console.WriteLine("Press any key to close");
Console.ReadKey();

 