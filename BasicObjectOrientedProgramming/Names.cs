using System.Xml;

namespace BasicObjectOrientedProgramming;

public class Names
{
    private List<string> _names = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();

    public void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
            _names.Add(name);
    }

    

    public string BuildFilePath()
    {
        return "names.txt";
    }

    public string Format()
    {
        return string.Join(Environment.NewLine, _names);
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