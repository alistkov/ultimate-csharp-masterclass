namespace NamesSingleResponsibilityPrinciple;

public class StringFormatter()
{
    public string Format(List<string> strings)
    {
        return string.Join(Environment.NewLine, strings);
    }
}