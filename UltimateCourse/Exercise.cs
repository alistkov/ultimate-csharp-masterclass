namespace UltimateCourse;

public class Exercise
{
    public List<string> ProcessAll(List<string> words)
    {
        var stringsProcessors = new List<StringsProcessor>
        {
            new StringsTrimmingProcessor(),
            new StringsUppercaseProcessor()
        };
    
        List<string> result = words;
        foreach (var stringsProcessor in stringsProcessors)
        {
            result = stringsProcessor.Process(result);
        }
        return result;
    }
}


public class StringsProcessor
{
    public virtual List<string> Process(List<string> words) => words;
}

public class StringsUppercaseProcessor : StringsProcessor
{
    public override List<string> Process(List<string> words)
    {
        var result = new List<string>();

        foreach (var word in words)
        {
            result.Add(word.ToUpper());
        }

        return result;
    }
}

public class StringsTrimmingProcessor : StringsProcessor
{
    public override List<string> Process(List<string> words)
    {
        var result = new List<string>();

        foreach (var word in words)
        {
            var stringLength = word.Length;
            result.Add(word.Substring(0, stringLength / 2));
        }

        return result;
    }
}