namespace UltimateCourse.UnderTheHood;

public class Exercise : IDisposable
{
    private readonly StreamReader _streamReader;
    
    public Exercise(string filePath)
    {
        _streamReader = new StreamReader(filePath);
    }
    
    public List<string> ReadAllLines()
    {
        var result = new List<string>();
        while (!_streamReader.EndOfStream) 
        {
            result.Add(_streamReader.ReadLine());
        }
    
        return result;
    }
    
    //your code goes here
    public void Dispose()
    {
        _streamReader.Dispose();
    }
}