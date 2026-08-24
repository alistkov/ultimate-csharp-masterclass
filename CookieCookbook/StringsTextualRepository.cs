namespace CookieCookbook;

public class StringsTextualRepository : IStringsRepository
{
    private static readonly string Separator = Environment.NewLine;

    public List<string> Read(string filePath)
    {
        if (File.Exists(filePath))
        {
            var fileContent = File.ReadAllText(filePath);
            return fileContent.Split(Separator).ToList();
        }

        return new List<string>();
    }

    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, string.Join(Separator, strings));
    }
}