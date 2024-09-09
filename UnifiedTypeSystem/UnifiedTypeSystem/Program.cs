using System.Collections;

int number = 5;
var person = new Person { Name = "Ted", Age = 19 };
object boxedNumber = number; //boxing (implicitely)
int unboxedNumber = (int)boxedNumber; // unboxing (explicitly)
IComparable<int> intAsComparable = number; // boxing - interface is refference type

var numbers1 = new List<int> { 1, 2, 3, 4, 5 };
var numbers2 = new ArrayList { 1, 2, 3, 4, 5 }; // it will be boxed

var numbers3 = new List<IComparable<int>> { 1, 2, 3, 4, 5 }; // it will be boxed, because Interface is refference type


var variousObjects = new List<object>//boxing
{
    1,
    1.5m,
    new DateTime(2024, 6, 30),
    "hello",
    new Person {Name = "Anna", Age = 61}
};

foreach (var variousObject in variousObjects)
{
    Console.WriteLine(variousObject.GetType().Name);
}

Console.ReadKey();

class Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}