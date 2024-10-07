var smallSubset = GenerateEvenNumbers()
    .Skip(5)
    .Take(10);

foreach (var number in GenerateEvenNumbers())
{
    if (number == 50)
    {
        break;
    }
    Console.WriteLine(number);
}

var firstEvenNumber = GenerateEvenNumbers().First();

Console.ReadKey();

IEnumerable<int> GenerateEvenNumbers()
{
    var result = new List<int>();

    for (int i = 0; i < int.MaxValue; i += 2)
    {
        result.Add(i);
    }

    return result;
}