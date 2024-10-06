// O(log N) logarithmic complexity - binary search algorithm

using System;
using System.Collections.Generic;

var sortedList = new List<int>
{
    1, 3, 4, 5, 6, 11, 12, 14, 18
};

var indexOf1 = sortedList.IndexOf(1);
var indexOf11 = sortedList.IndexOf(11);
var indexOf12 = sortedList.IndexOf(18);
var indexOf18 = sortedList.IndexOf(12);
var indexOf13 = sortedList.IndexOf(13);

Console.ReadKey();
public static class Extensions
{
    public static int? BinarySearch<T>(this IList<T> input, T itemToFind) where T : IComparable<T>
    {
        int leftBound = 0;
        int rightBound = input.Count - 1;

        while (leftBound <= rightBound)
        {
            int middleIndex = (leftBound + rightBound) / 2;

            if (itemToFind.Equals(input[middleIndex]))
            {
                return middleIndex;
            }
            else if (itemToFind.CompareTo(input[middleIndex]) < 0)
            {
                rightBound = middleIndex - 1;
            }
            else
            {
                leftBound = middleIndex + 1;
            }
        }

        return null;
    }
}
