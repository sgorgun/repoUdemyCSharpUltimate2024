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

AddOneToNumber(number);
AddOneToPerson(john);

Console.WriteLine("Number is " + number);
Console.WriteLine("John's age is " + john.Age);

Console.ReadKey();

void AddOneToNumber(int number)
{
    ++number;
}

void AddOneToPerson(Person person)
{
    ++person.Age;
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}