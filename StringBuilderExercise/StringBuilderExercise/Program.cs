using System;
using System.Text;

namespace Coding.Exercise
{
    public static class StringBuilderExercise
    {
        public static string Reverse(string input)
        {
            var stringBuilder = new StringBuilder();
            for (int i = input.Length - 1; i > -1; i--)
            {
                stringBuilder.Append(input[i]);
            }

            return stringBuilder.ToString();
        }
    }
}