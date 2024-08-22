using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = new Tuple<int, string>(1, "hello");
            var output = input.SwapTupleItems();
            Console.WriteLine($"Swapped Tuple: Item1 = {output.Item1}, Item2 = {output.Item2}");
            Console.ReadKey();
        }
    }

    public static class TupleSwapExercise
    {
        public static Tuple<T2, T1> SwapTupleItems<T1, T2>(this Tuple<T1, T2> input) =>
            new(input.Item2, input.Item1);
    }
}