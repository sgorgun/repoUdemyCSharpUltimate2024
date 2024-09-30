using OpenStarwarsApi.DTOs;
using OpenStarwarsApi.MockApiDataAccess;
using System.Text.Json;

var baseAddress = "https://swapi.dev/";
var requestUri = "api/planets";

IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read(baseAddress, requestUri);

Console.WriteLine("Press any key to close.");
var root = JsonSerializer.Deserialize<Root>(json);

Console.ReadKey();
