namespace CookieCookbook.DataAccess;

public class StringsTextualRepository : StringRepository
{
    private static readonly string Separator = Environment.NewLine;


    protected override List<string> TextToStrings(string fileContent) =>
        fileContent.Split(Separator).ToList();

    protected override string StringToText(List<string> strings) =>
        string.Join(Separator, strings);
}