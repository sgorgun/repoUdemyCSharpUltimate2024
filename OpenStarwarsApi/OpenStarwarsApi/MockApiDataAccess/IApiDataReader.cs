namespace OpenStarwarsApi.MockApiDataAccess;

public interface IApiDataReader
{
    Task<string> Read(string baseAddress, string requestUri);
}
