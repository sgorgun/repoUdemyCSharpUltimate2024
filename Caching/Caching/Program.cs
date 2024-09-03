var dataDownloader = new SlowDataDownloader();

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

public interface IDataDownloader
{
    string DownloadData(string resourceId);
}

public class SlowDataDownloader : IDataDownloader
{
    private readonly Cache<string, string> _cache = new();
    public string DownloadData(string resourceId)
    {
        return _cache.Get(resourceId, DownloadDataWithoutCaching);
    }
    
    private string DownloadDataWithoutCaching(string resourceId)
    {
        Thread.Sleep(1000);
        return $"Some data for {resourceId}";
    }
}