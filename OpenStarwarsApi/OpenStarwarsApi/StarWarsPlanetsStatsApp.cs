using OpenStarwarsApi.DTOs;
using OpenStarwarsApi.MockApiDataAccess;
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
    }
}