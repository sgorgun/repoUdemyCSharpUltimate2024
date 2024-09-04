using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var wordsNoUpperCase = new string[]
        {
            "quick", "brown", "fox"
        };
        Console.WriteLine(IsAnyWordUpperCase(wordsNoUpperCase));
        Console.WriteLine(IsAnyWordUpperCaseLinq(wordsNoUpperCase));

        
        var wordsUpperCase = new string[]
        {
            "quick", "brown", "FOX"
        };
        Console.WriteLine(IsAnyWordUpperCase(wordsUpperCase));
        Console.WriteLine(IsAnyWordUpperCaseLinq(wordsUpperCase));

        Console.ReadKey();
    }

    public static bool IsAnyWordUpperCaseLinq(IEnumerable<string> words)
    {
        return words.Any(word => word.All(letter => char.IsUpper(letter)));
    }

    public static bool IsAnyWordUpperCase(IEnumerable<string> words)
    {
        foreach (string word in words)
        {
            bool areAllUpperCase = true;
            foreach (var letter in word)
            {
                if (char.IsLower(letter))
                {
                    areAllUpperCase = false;
                }
            }

            if (areAllUpperCase)
            {
                return true;
            }
        }
        return false;
    }
}
