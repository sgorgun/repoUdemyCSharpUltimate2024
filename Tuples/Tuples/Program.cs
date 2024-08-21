var numbers = new List<int> { 5, 3, 2, 8, 16, 7 };
SimpleTuple<int, int> minAndMax = GetMinAndMax(numbers);

var twoStrings = new SimpleTuple<string, string>("aaa", "bbb");
var differentTypes = new SimpleTuple<string, int>("aaa", 11);
var threeTypes = new SimpleTuple<string, int, bool>("aaa", 11, false);

Console.WriteLine("Smallest number is " + minAndMax.ItemOne);
Console.WriteLine("Largest number is " + minAndMax.ItemTwo);

Console.ReadKey();

SimpleTuple<int, int> GetMinAndMax(IEnumerable<int> input)
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

    return new SimpleTuple<int, int>(min, max);
}

bool IsEmpty(IEnumerable<int> input)
{
    foreach (int num in input)
    {
        return false;
    }

    return true;
}

public class SimpleTuple<T1, T2>
{
    public T1 ItemOne { get; }
    public T2 ItemTwo { get; }

    public SimpleTuple(T1 itemOne, T2 itemTwo)
    {
        this.ItemOne = itemOne;
        this.ItemTwo = itemTwo;
    }
}
public class SimpleTuple<T1, T2, T3>
{
    public T1 ItemOne { get; }
    public T2 ItemTwo { get; }
    public T3 ItemThree { get; }

    public SimpleTuple(T1 itemOne, T2 itemTwo, T3 itemThree)
    {
        this.ItemOne = itemOne;
        this.ItemTwo = itemTwo;
        this.ItemThree = itemThree;
    }
}