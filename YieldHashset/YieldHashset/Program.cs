var input = new[] { "a", "b", "a", "c", "d", "b" };
foreach (var item in Distinct(input))
{
    Console.WriteLine(item);
}

Console.ReadKey();

IEnumerable<T> Distinct<T>(IEnumerable<T> input)
{
    var hashSet = new HashSet<T>();
    foreach (var item in input)
    {
        if (!hashSet.Contains(item))
        {
            hashSet.Add(item);
            yield return item;
            Console.WriteLine("After yield.");
        }
    }
}