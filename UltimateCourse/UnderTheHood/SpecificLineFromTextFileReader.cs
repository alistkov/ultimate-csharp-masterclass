namespace UltimateCourse.UnderTheHood;

public class SpecificLineFromTextFileReader(string filePath)
{
    private readonly StreamReader _streamReader = new StreamReader(filePath);

    public string ReadLineNumber(int lineNumber)
    {
        _streamReader.DiscardBufferedData();
        _streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
        
        for (int i = 0; i < lineNumber - 1; i++)
        {
            _streamReader.ReadLine();
        }

        return _streamReader.ReadLine();
    }
}