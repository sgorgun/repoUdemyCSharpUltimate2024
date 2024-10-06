var planets = ReadPlanets();
planets.Clear();

Console.ReadKey();

List<string> ReadPlanets()
{
    var result = new List<string>
    {
        "Alderaan",
        "Coruskant",
        "Bespin"
    };

    return result;
}