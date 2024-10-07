using System;

namespace Coding.Exercise
{
    public static class HashSetsUnionExercise
    {
        public static HashSet<T> CreateUnion<T>(
            HashSet<T> set1, HashSet<T> set2)
        {
            HashSet<T> result = new HashSet<T>(set1);
            foreach (var item in set2)
            {
                result.Add(item);
            }
            return result;
        }
    }
}