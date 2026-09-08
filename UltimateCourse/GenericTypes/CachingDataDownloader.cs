namespace UltimateCourse.GenericTypes;

public class CachingDataDownloader(IDataDownloader dataDownloader) : IDataDownloader
{
    private readonly IDataDownloader _dataDownloader = dataDownloader;
    private readonly Cache<string, string> _cache = new();
    
    public string DownloadData(string resourceId)
    {
        return _cache.Get(resourceId, _dataDownloader.DownloadData);
    }
}