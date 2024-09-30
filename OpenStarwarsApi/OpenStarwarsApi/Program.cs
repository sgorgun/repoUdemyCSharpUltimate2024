using OpenStarwarsApi.DTOs;
using OpenStarwarsApi.MockApiDataAccess;
using System.Text.Json;

try
{
	await new StarWarsPlanetsStatsApp(
        new ApiDataReader(),
        new MockStarWarsApiDataReader()).Run();
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred. " +
        "Exception message: " + ex.Message);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();
