//Console.WriteLine("Ente a number:");
//string input = Console.ReadLine();
//try
//{
//    int number = ParseStringToInt(input);
//    var result = 10 / number;
//    Console.WriteLine($" 10 / {number} is " + result);
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Wrong format. Input string is not parsable to int. Exeption message: " + ex.Message );
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Division by zero is invalid operation. Exception message: " + ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Unexpected error occurred. Exception message: " + ex.Message);
//}
//finally
//{
//    Console.WriteLine("Finaly block is being executed.");
//}

//Console.ReadKey();
//int ParseStringToInt(string input)
//{
//    return int.Parse(input);
//}



//var result = GetFirstElement(new int[0]);

//Console.ReadKey();

//int GetFirstElement(IEnumerable<int> numbers)
//{
//    foreach (int number in numbers)
//    {
//        return number;
//    }

//    throw new Exception("The collection cannot be empty.");
//}




var invalidPersonObject = new Person("", -100);

Console.ReadKey();
class Person
{
    public string Name { get; }
    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        if (name == String)
        {

        }
        Name = name;
        YearOfBirth = yearOfBirth;
    }
}