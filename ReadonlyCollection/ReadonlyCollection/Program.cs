using System.Collections.ObjectModel;

var planets = ReadPlanets();
var asList = (ReadOnlyCollection<string>)planets; 
//asList.Clear(); not compile anymore

var dictionary = new Dictionary<string, int>
{
    ["aaa"] = 1
};

var readonlyDictionary = new ReadOnlyDictionary<string, int>(dictionary);
//readonlyDictionary.Clear(); // it isn't copile

Console.ReadKey();

IEnumerable<string> ReadPlanets()
{
    var result = new List<string>
    {
        "Alderaan",
        "Coruskant",
        "Bespin"
    };

    return new ReadOnlyCollection<string> (result);
}