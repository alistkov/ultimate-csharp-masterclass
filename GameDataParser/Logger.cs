public class Logger(string logFileName)
{
    private readonly string _logFileName = logFileName;

    public void Log(Exception ex)
    {
        var entry =
            $@"[{DateTime.Now}]
             Exception message: {ex.Message}
             Stack trace: {ex.StackTrace}

        ";

        File.AppendAllText(_logFileName, entry);
    }
}