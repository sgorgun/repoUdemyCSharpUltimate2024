using System;

var decimals = new List<decimal> { 1.1m, 0.5m, 22.5m, 12m };
var ints = decimals.ConvertTo<decimal, int>();

Console.ReadKey();

static class ListExtensions
{
    public static void AddToFront<T>(this List<T> list, T item)
    {
        list.Insert(0, item);
    }

    public static List<TTarget> ConvertTo<TSource, TTarget>(this List<TSource> input)
    {
        var result = new List<TTarget>();

        foreach (var item in input)
        {
            result.Add((TTarget)item);
        }

        return result;
    }
}