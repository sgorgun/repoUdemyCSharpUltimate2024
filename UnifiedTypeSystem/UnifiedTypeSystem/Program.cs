var variousObjects = new List<object>
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