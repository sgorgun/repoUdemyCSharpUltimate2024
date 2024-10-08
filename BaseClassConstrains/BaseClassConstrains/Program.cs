﻿var numbers = new List<int> { 5, 1, 7, 2 };
numbers.Sort();

var words = new List<string> { "ddd", "aaa", "ccc", "bbb" };
words.Sort();

var people = new List<Person>
{
    new Person {Name = "John", YearOfBirth = 1980},
    new Person {Name = "Anna", YearOfBirth = 1880},
    new Person {Name = "Bill", YearOfBirth = 2980},
};
people.Sort();

var employees = new List<Employee>
{
    new Employee {Name = "John", YearOfBirth = 1980},
    new Employee {Name = "Anna", YearOfBirth = 1880},
    new Employee {Name = "Bill", YearOfBirth = 2980},
};

var john = new Person { Name = "John", YearOfBirth = 1980 };
var anna = new Person { Name = "Anna", YearOfBirth = 1880 };


var validPeople = GetOnlyValid(people);
var validEmployees = GetOnlyValid(employees);

foreach (var person in validEmployees)
{
    person.GoToWork(); // NO cast here
}

PrintInOrder(10, 5);
PrintInOrder("bbb", "aaa");
PrintInOrder(anna, john);


Console.ReadKey();

void PrintInOrder<T>(T first, T second) where T: IComparable<T> // Arguguments of generic type constrained
{
    if (first.CompareTo(second) > 0)
    {
        Console.WriteLine(second + " " + first);
    }
    else
    {
        Console.WriteLine(first + " " + second);
    }
}

IEnumerable<TPerson> GetOnlyValid<TPerson>(IEnumerable<TPerson> persons) where TPerson : Person // Added generics and dirived class constrain here
{
    var results = new List<TPerson>();

    foreach (var person in persons)
    {
        if (person.YearOfBirth < DateTime.Now.Year && person.YearOfBirth > 1900)
        {
            results.Add(person);
        }
    }

    return results;
}

public class Person : IComparable<Person>
{
    public string Name { get; init; }
    public int YearOfBirth { get; init; }

    public override string ToString() => $"{Name} born in {YearOfBirth}"; // Don't foget it for correct

    public int CompareTo(Person other)
    {
        if (this.YearOfBirth < other.YearOfBirth)
        {
            return 1;
        }
        else if (this.YearOfBirth > other.YearOfBirth)
        {
            return -1;
        }

        return 0;
    }
}

public class Employee : Person
{
    public void GoToWork() => Console.WriteLine("Going to work");
}