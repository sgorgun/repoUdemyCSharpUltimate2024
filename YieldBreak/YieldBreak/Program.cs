var numbers = new int[] { 1, 4, 2, -5, 6, -2, 1 };
foreach (var number in GetBeforeFirstNegative(numbers))
{
    Console.WriteLine(number);
}

Console.ReadKey();

IEnumerable<int> GetBeforeFirstNegative(IEnumerable<int> input)
{
    foreach (int number in input)
    {
        if (number >= 0)
        {
            yield return number;
        }

        else
        {
            yield break; 
        }
    }
}