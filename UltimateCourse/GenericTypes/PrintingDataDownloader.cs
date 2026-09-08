namespace UltimateCourse.GenericTypes;

public class PrintingDataDownloader(IDataDownloader dataDownloader) : IDataDownloader
{
    private readonly IDataDownloader _dataDownloader = dataDownloader;
    
    public string DownloadData(string resourceId)
    {
        var data = _dataDownloader.DownloadData(resourceId);
        Console.WriteLine("Data is ready!");
        return data;
    }
}