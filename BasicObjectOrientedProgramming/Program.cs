using BasicObjectOrientedProgramming;

var names = new Names();
var path = names.BuildFilePath();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Load names");
    names.ReadFromTextFile();
}
else
{
    Console.WriteLine("Names file does not yet exist.");
    
    names.AddName("John");
    names.AddName("not valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");
    
    Console.WriteLine("Saving names to a file.");
    names.WriteToTextFile();
}

Console.WriteLine(names.Format());