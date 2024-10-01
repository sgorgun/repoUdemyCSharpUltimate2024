using OpenStarwarsApi.DTOs;
using OpenStarwarsApi.MockApiDataAccess;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

public class StarWarsPlanetsStatsApp
{
    private readonly IApiDataReader _apiDataReader;
    private readonly IApiDataReader _secondaryApiDataReader;

    public StarWarsPlanetsStatsApp(IApiDataReader apiDataReader, IApiDataReader secondaryApiDataReader)
    {
        _apiDataReader = apiDataReader;
        _secondaryApiDataReader = secondaryApiDataReader;
    }

    public async Task Run()
    {
        var baseAddress = "https://swapi.dev/";
        var requestUri = "api/planets";
        string? json = null;


        try
        {
            json = await _apiDataReader.Read(baseAddress, requestUri);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("API request was unsuccessful. " +
                "Swiching to mock data. " +
                "Exception message: " + ex.Message);
        }

        if (json is null)
        {
            json = await _secondaryApiDataReader.Read(baseAddress, requestUri);
        }

        var root = JsonSerializer.Deserialize<Root>(json);
        var planets = ToPlanets(root);

        foreach (var planet in planets)
        {
            Console.WriteLine(planet);
        }

        Console.WriteLine();
        Console.WriteLine("The static of which propperty woud you like to see?");
        Console.WriteLine("population");
        Console.WriteLine("diameter");
        Console.WriteLine("surface wather");

        var userChoise = Console.ReadLine();

        if (userChoise == "population")
        {
            ShowStatistic(planets, "population", planet => planet.Population);
        }
        else if (userChoise == "diameter")
        {
            ShowStatistic(planets, "diameter", planet => planet.Diameter);
        }
        else if (userChoise == "surface wather")
        {
            ShowStatistic(planets, "surface wather", planet => planet.SurfaceWater);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    private void ShowStatistic(
        IEnumerable<Planet> planets,
        string propertyName,
        Func<Planet, int?> propertySelector)
    {
        var planetWithMaxPropertyValue =
    planets.MaxBy(propertySelector);

        Console.WriteLine($"Max {propertyName} wather is: " +
            propertySelector(planetWithMaxPropertyValue) +
            $" planet: {planetWithMaxPropertyValue.Name}");

        var planetWithMinPropertyValue =
            planets.MinBy(propertySelector);

        Console.WriteLine($"Min {propertyName} wather is: " +
            propertySelector(planetWithMinPropertyValue) +
            $" (planet: {planetWithMinPropertyValue.Name})");
    }

    private IEnumerable<Planet> ToPlanets(Root? root)
    {
        if (root == null)
        {
            throw new ArgumentNullException(nameof(root));
        }

        var planets = new List<Planet>();

        foreach (var planetDTO in root.Results)
        {
            Planet planet = (Planet)planetDTO;
            planets.Add(planet);
        }

        return planets;
    }
}