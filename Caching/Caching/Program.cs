//var dataDownloader = new SlowDataDownloader();// Don't using caching
IDataDownloader dataDownloader = new CachigDataDownloader(new SlowDataDownloader());// Using caching

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

Console.ReadKey();

public class Cache<TKey,TData>
{
    private readonly Dictionary<TKey, TData> _cacheData = new();

    public TData Get(TKey key, Func<TKey, TData> getForTheFirstTime)
    {
        if (!_cacheData.ContainsKey(key))
        {
            _cacheData[key] = getForTheFirstTime(key);
        }

        return _cacheData[key];
    }
}

public class CachigDataDownloader : IDataDownloader
{
    private readonly IDataDownloader _dataDownloader;
    private readonly Cache<string, string> _cache = new();

    public CachigDataDownloader(IDataDownloader dataDownloader)
    {
        _dataDownloader = dataDownloader;
    }

    public string DownloadData(string resourceId)
    {
        return _cache.Get(resourceId, _dataDownloader.DownloadData);
    }
}

public interface IDataDownloader
{
    string DownloadData(string resourceId);
}

public class SlowDataDownloader : IDataDownloader
{ 
    public string DownloadData(string resourceId)
    {
        Thread.Sleep(1000);
        return $"Some data for {resourceId}";
    }
}