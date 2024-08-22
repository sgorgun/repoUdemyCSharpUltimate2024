using System.Diagnostics;

Stopwatch sw = Stopwatch.StartNew();
var ints = CreateCollectionsOfRandomLength<long>(0);
sw.Stop();
Console.WriteLine($"Execution took {sw.ElapsedMilliseconds} ms.");

Console.ReadKey();

IEnumerable<T> CreateCollectionsOfRandomLength<T>(int maxLength) where T : new()
{
    var length = 100_000_000; //new Random().Next(maxLength + 1);
    var result = new List<T>();
    
    for (int i = 0; i < length; ++i)
    {
        result.Add(new T());
    }

    return result;
}