var people = new List<Person>
{
    new Person {Name = "John", YearOfBirth = 1980},
    new Person {Name = "Anna", YearOfBirth = 1880},
    new Person {Name = "Bill", YearOfBirth = 2980},
};

var employees = new List<Employee>
{
    new Employee {Name = "John", YearOfBirth = 1980},
    new Employee {Name = "Anna", YearOfBirth = 1880},
    new Employee {Name = "Bill", YearOfBirth = 2980},
};


var validPeople = GetOnlyValid(people);
var validEmployees = GetOnlyValid(employees);

foreach (var person in validEmployees)
{
    ((Employee)person).GoToWork(); // cast here
}

Console.ReadKey();

IEnumerable<Person> GetOnlyValid(IEnumerable<Person> persons)
{
    var results = new List<Person>();

    foreach (var person in persons)
    {
        if (person.YearOfBirth < DateTime.Now.Year && person.YearOfBirth > 1900)
        {
            results.Add(person);
        }
    }

    return results;
}

public class Person
{
    public string Name { get; init; }
    public int YearOfBirth { get; init; }
}

public class Employee : Person
{
    public void GoToWork() => Console.WriteLine("Going to work");
}