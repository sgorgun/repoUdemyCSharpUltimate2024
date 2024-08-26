using static System.Runtime.InteropServices.JavaScript.JSType;

int a = 5;
var john = new Person("John", "Smith", 1981);

var numbers = new[] { 1, 4, 7, 19, 2 };

Func<int, bool> predicate = IsAnyLagerThan10;

Console.WriteLine("IsAnyLagerThan10?" + IsAny(numbers, predicate));
Console.WriteLine("IsAnyEven?" + IsAny(numbers, IsAnyEven));

Func<int, DateTime, string, decimal> someFunc; // all parameters are input instead of last. Last parameter is output.
Action<string, string, bool> someAction; // all parameters are input. Action use for void action without output.

Console.ReadKey();

bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number)) return true;
    }
    return false;
}

bool IsAnyLagerThan10(int number) //method1
{
    return number > 10;
}
bool IsAnyEven(int number) // method2
{
    return number % 2 == 0;
}

public class Person(string firstName, string secondName, int yearOfBirth)
{
    private string FirstName { get; set; } = firstName;
    private string SecondName { get; set; } = secondName;
    private int yearOfBirth { get; set; } = yearOfBirth;
}
