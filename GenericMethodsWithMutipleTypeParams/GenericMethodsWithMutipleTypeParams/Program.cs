using System;

var decimals = new List<decimal> { 1.1m, 0.5m, 22.5m, 12m };
var ints = decimals.ConvertTo();

Console.ReadKey();

static class ListExtensions
{
    public static void AddToFront<T>(this List<T> list, T item)
    {
        list.Insert(0, item);
    }

    public static List<int> ConvertTo(this List<decimal> decimals)
    {
        var result = new List<int>();

        foreach (var item in decimals)
        {
            result.Add((int)item);
        }

        return result;
    }
}