var evenNumbers = GenerateEvenNumbers();
var firstThreeEvenNumbers = evenNumbers.Take(3).ToList();

foreach (var evenNumber in firstThreeEvenNumbers)
{
    Console.WriteLine($"Number is {evenNumber}");
}

foreach (var evenNumber in firstThreeEvenNumbers)
{
    Console.WriteLine($"Number is {evenNumber}");
}

Console.ReadKey();

IEnumerable<int> GenerateEvenNumbers()
{
    for (int i = 0; i < int.MaxValue; i += 2)
    {
        Console.WriteLine($"Yielding {i}");        
        yield return i;
    }
}