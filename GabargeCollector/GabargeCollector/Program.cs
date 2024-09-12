using System;

string userInput = Console.ReadLine();
if (userInput == "Print r=person")
{
    Person person = new Person("Shivay", 37);
    Console.WriteLine($"{person.Name} is {person.Age} years old.");
}

GC.Collect();

Console.ReadKey();

public class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
}