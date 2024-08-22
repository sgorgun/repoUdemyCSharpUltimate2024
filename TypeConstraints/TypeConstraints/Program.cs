var ints = CreateCollectionsOfRandomLength<long>(100);

Console.ReadKey();

IEnumerable<T> CreateCollectionsOfRandomLength<T>(int maxLength) where T : new()
{
    var length = new Random().Next(maxLength + 1);
    var result = new List<T>();
    
    for (int i = 0; i < length; ++i)
    {
        result.Add(new T());
    }

    return result;
}