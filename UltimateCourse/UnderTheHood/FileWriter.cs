namespace UltimateCourse.UnderTheHood;

public class FileWriter(string filePath)
{
    private readonly StreamWriter _streamWriter = new StreamWriter(filePath, true);
    
    public void Write(string text)
    {
        _streamWriter.WriteLine(text);
        _streamWriter.Flush();
    }
}