int number = 5;
int anotherNumber = number;
anotherNumber++;

//Console.WriteLine("Number is " + number);
//Console.WriteLine("anotherNumber is " + anotherNumber);

var john = new Person { Name = "John", Age = 34 };
//var person = john;
//Console.WriteLine("John's age is " + john.Age);
//person.Age = 35;
//Console.WriteLine("John's age is " + john.Age);
//Console.WriteLine("Person's age is " + person.Age);

AddOneToNumber(ref number);
AddOneToPerson(john);

Console.WriteLine("Number is " + number);
Console.WriteLine("John's age is " + john.Age);

MethodWithOutParameter(out int otherNumber);
Console.WriteLine("otherNumber: " + otherNumber);

var list = new List<int> {  1, 2, 3 };
AddOneToList(ref list);
Console.WriteLine(string.Join(", ", list));

Console.ReadKey();

void AddOneToList(ref List<int> numbers) // null usung ref
{
    numbers = null;
}
void MethodWithOutParameter(out int number)
{
    number = 10;
}

void AddOneToNumber(ref int number)
{
    ++number;
}

//void AddOneToPerson(Person person)
//{
//    ++person.Age;
//}

Person AddOneToPerson(Person person)
{
    return new Person { Name = person.Name, Age = person.Age + 1 };
}

struct Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}