namespace CookieCookbook.DataAccess;

public abstract class StringRepository : IStringsRepository
{
    public List<string> Read(string filePath)
    {
        if (File.Exists(filePath))
        {
            var fileContent = File.ReadAllText(filePath);
            return TextToStrings(fileContent);
        }

        return new List<string>();
    }

    protected abstract List<string> TextToStrings(string fileContent);

    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, StringToText(strings));
    }

    protected abstract string StringToText(List<string> strings);
}