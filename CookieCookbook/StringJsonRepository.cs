using System.Text.Json;

namespace CookieCookbook;

public class StringJsonRepository : IStringsRepository
{
    private static readonly string Separator = Environment.NewLine;

    public List<string> Read(string filePath)
    {
        if (File.Exists(filePath))
        {
            var fileContent = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<string>>(fileContent);
        }

        return new List<string>();
    }

    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, JsonSerializer.Serialize(strings));
    }
}