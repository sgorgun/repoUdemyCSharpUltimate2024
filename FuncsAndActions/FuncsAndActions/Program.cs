int a = 5;
var john = new Person("John", "Smith", 1981);

var numbers = new[] { 1, 4, 7, 19, 2 };
Console.WriteLine("IsAnyLagerThan10?" + IsanyLagerThan10(numbers));
Console.WriteLine("IsAnyEven?" + IsAnyEven(numbers));

Console.ReadKey();

bool IsanyLagerThan10(IEnumerable<int> numbers) //method1
{
    foreach (var number in numbers)
    {
        if (number > 10) return true; //difference
    }
    return false;
}bool IsAnyEven(IEnumerable<int> numbers) // method2
{
    foreach (var number in numbers) 
    {
        if (number % 2 == 0) return true; //difference
    }
    return false;
}

public class Person(string firstName, string secondName, int yearOfBirth)
{
    private string FirstName { get; set; } = firstName;
    private string SecondName { get; set; } = secondName;
    private int yearOfBirth { get; set; } = yearOfBirth;
}
