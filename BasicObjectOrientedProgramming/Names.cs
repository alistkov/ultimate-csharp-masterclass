using System.Xml;

namespace BasicObjectOrientedProgramming;

public class Names
{
    public List<string> All { get; } = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();
    
    public void AddNames(List<string> stringFromFile)
    {
        foreach (var name in stringFromFile)
        {
            AddName(name);
        }
    }

    public void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
            All.Add(name);
    }

    public string BuildFilePath()
    {
        return "names.txt";
    }

    public string Format()
    {
        return string.Join(Environment.NewLine, All);
    }
}

public class NamesValidator()
{
    public bool IsValid(string name)
    {
        return name.Length >= 2 &&
               name.Length < 25 &&
               char.IsUpper(name[0]) &&
               name.All(char.IsLetter);
    }
}

public class StringsTexturalRepository()
{
    private static readonly string Separator = Environment.NewLine;
    public List<string> Read(string path)

    {
        var fileContents = File.ReadAllText(path);
        return fileContents.Split(Separator).ToList();
    }

    public void Write(string path, List<string> strings)
    {
        File.WriteAllText(path, string.Join(Separator, strings));
    }
}