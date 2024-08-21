var numbers = new List<int> { 5, 3, 2, 8, 16, 7 };
TwoInts minAndMax = GetMinAndMax(numbers);
Console.WriteLine("Smallest number is " + minAndMax.IntOne);
Console.WriteLine("Largest number is " + minAndMax.IntTwo);

Console.ReadKey();

TwoInts GetMinAndMax(IEnumerable<int> input)
{
    if (IsEmpty(input))
    {
        throw new InvalidOperationException($"The input collection cannot be empty");
    }

    int min = int.MaxValue;
    int max = int.MinValue;

    foreach (int num in input)
    {
        if (num < min)
        {
            min = num;
        }

        if (num > max)
        {
            max = num;
        }
    }

    return new TwoInts(min, max);
}

bool IsEmpty(IEnumerable<int> input)
{
    foreach (int num in input)
    {
        return false;
    }

    return true;
}

public class TwoInts
{
    public int IntOne { get; }
    public int IntTwo { get; }

    public TwoInts(int intOne, int intTwo)
    {
        this.IntOne = intOne;
        this.IntTwo = intTwo;
    }
}