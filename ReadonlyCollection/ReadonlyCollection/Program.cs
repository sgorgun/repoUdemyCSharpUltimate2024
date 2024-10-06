var planets = ReadPlanets();
var asList = (List<string>)planets;
asList.Clear();

Console.ReadKey();

IEnumerable<string> ReadPlanets()
{
    var result = new List<string>
    {
        "Alderaan",
        "Coruskant",
        "Bespin"
    };

    return result;
}