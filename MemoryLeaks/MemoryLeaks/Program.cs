bool someCondition = true;

if (someCondition)
{
    var someClassInstance = new SomeClass(); 
}

Console.WriteLine("Count of all instance is now " + SomeClass.CountOfInstances);

Console.ReadKey();

public class SomeClass
{
    private static List<SomeClass> _allExistingInstances = new List<SomeClass>();

    public static int CountOfInstances => _allExistingInstances.Count;

    public SomeClass()
    {
        _allExistingInstances.Add(this);
    }
}