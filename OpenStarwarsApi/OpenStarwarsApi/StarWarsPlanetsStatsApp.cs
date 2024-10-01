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

        json ??= await _secondaryApiDataReader.Read(baseAddress, requestUri);

        var root = JsonSerializer.Deserialize<Root>(json);
        var planets = ToPlanets(root);

        foreach (var planet in planets)
        {
            Console.WriteLine(planet);
        }


        var propertyNamesToSelectorsMapping = new Dictionary<string, Func<Planet, int?>>
        {
            ["population"] = planet => planet.Population,
            ["diameter"] = planet => planet.Diameter,
            ["surface wather"] = planet => planet.SurfaceWater
        };

        Console.WriteLine();
        Console.WriteLine("The static of which propperty woud you like to see?");
        Console.WriteLine(string.Join(Environment.NewLine, propertyNamesToSelectorsMapping.Keys));

        var userChoise = Console.ReadLine();

        if (userChoise is null || !propertyNamesToSelectorsMapping.ContainsKey(userChoise))
        {
            Console.WriteLine("Invalid choice.");
        }
        else
        {
            ShowStatistic(planets, userChoise, propertyNamesToSelectorsMapping[userChoise]);
        }
    }

    private static void ShowStatistic(
        IEnumerable<Planet> planets,
        string propertyName,
        Func<Planet, int?> propertySelector)
    {
        ShowStatistic(
            "Max",
            planets.MaxBy(propertySelector),
            propertySelector,
            propertyName);

        ShowStatistic(
            "Min",
            planets.MinBy(propertySelector),
            propertySelector,
            propertyName);
    }

    private static void ShowStatistic(
        string descriptor,
        Planet selectedPlanet,
        Func<Planet, int?> propertySelector,
        string propertyName)
    {
        Console.WriteLine($"{descriptor} {propertyName} is: " +
            propertySelector(selectedPlanet) +
            $" planet: {selectedPlanet.Name}");
    }

    private IEnumerable<Planet> ToPlanets(Root? root)
    {
        if (root == null)
        {
            throw new ArgumentNullException(nameof(root));
        }

        return root.Results.Select(
            planetDTO => (Planet)planetDTO);
    }
}