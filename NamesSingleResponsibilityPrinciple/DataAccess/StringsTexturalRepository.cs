namespace NamesSingleResponsibilityPrinciple.DataAccess;

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