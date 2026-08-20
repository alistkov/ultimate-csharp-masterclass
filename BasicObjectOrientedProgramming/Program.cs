using BasicObjectOrientedProgramming;

var names = new Names();
var path = names.BuildFilePath();
var stringsTexturalRepository = new StringsTexturalRepository();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Load names");
    var stringFromFile = stringsTexturalRepository.Read(path);
    names.AddNames(stringFromFile);
}
else
{
    Console.WriteLine("Names file does not yet exist.");
    
    names.AddName("John");
    names.AddName("not valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");
    
    Console.WriteLine("Saving names to a file.");
    stringsTexturalRepository.Write(path, names.All);
}

Console.WriteLine(names.Format());