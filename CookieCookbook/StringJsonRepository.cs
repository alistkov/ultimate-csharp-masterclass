using System.Text.Json;

namespace CookieCookbook;

public class StringJsonRepository : StringRepository
{
    protected override List<string> TextToStrings(string fileContent) =>
        JsonSerializer.Deserialize<List<string>>(fileContent);

    protected override string StringToText(List<string> strings) =>
        JsonSerializer.Serialize(strings);
}