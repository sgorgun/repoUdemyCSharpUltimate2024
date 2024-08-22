using System.Collections;

ArrayList ints = new ArrayList { 2, 3, 4, 5 }; // boxing/unboxing
int sum = 0;
foreach (var number in ints)
{
    sum += (int)number;
}

var integers = new List<int> { 2, 3, 4, 5 }; // without boxing/unboxing
int result = 0;
foreach (var number in integers)
{
    result += number;
}

ArrayList strings = new ArrayList { "a", "b", "c" };

ArrayList  variousObj = new ArrayList { 1, "a", false, new DateTime() };
object[] obj = new object[] { 1, "a", false, new DateTime() };

Console.ReadKey();