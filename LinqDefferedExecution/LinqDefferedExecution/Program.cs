var words = new List<string> { "a", "bb", "ccc", "dddd" };

var shortWords = words.Where(word => word.Length < 3).ToList(); //With ToList query is materialised. Without ToList it execute in foreach only.

Console.WriteLine("First iteration");
foreach (var word in shortWords)
{
    Console.WriteLine(word);
}

words.Add("e");

Console.WriteLine("Second iteration");
foreach (var word in shortWords)
{
    Console.WriteLine(word);
}

var people = new List<Person>
{
    new Person("John", "USA"),
    new Person("Betty", "UK"),
};

var allAmericans = people.Where(person => person.Country == "USA");
var notAllAmericans = allAmericans.Take(100);

var animals = new List<string>()
{
    "Duck", "Lion", "Dolphin", "Tiger"
};

var animalWithD = animals.Where(animal =>
{
    Console.WriteLine("Checking animal: " + animal);
    return animal.StartsWith('D');
});

foreach (var animal in animalWithD)
{
    Console.WriteLine(animal);
}
Console.ReadKey();

public class Person(string name, string country)
{
    public string Name { get; set; } = name;
    public string Country { get; set; } = country;
}