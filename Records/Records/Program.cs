//var weatherData = new WeatherData(25.1m, 65);
//Console.WriteLine(weatherData);

//var warmerWeatherData = weatherData with { Temperature = 30 };

var rectangle = new Rectangle(3, 4);
//rectangle.A = 30;

Console.ReadKey();

public record WeatherData(decimal Temperature, int Humidity);
public readonly record struct Rectangle(int A, int B);


//public class WeatherData : IEquatable<WeatherData?>
//{
//    public decimal Temperature { get; }
//    public int Humidity { get; }

//    public WeatherData(decimal temperature, int humidity)
//    {
//        Temperature = temperature;
//        Humidity = humidity;
//    }

//    public override string ToString()
//    {
//        return $"Temperature: {Temperature}, Humidity: {Humidity}";
//    }

//    public override bool Equals(object? obj)
//    {
//        return Equals(obj as WeatherData);
//    }

//    public bool Equals(WeatherData? other)
//    {
//        return other is not null &&
//               Temperature == other.Temperature &&
//               Humidity == other.Humidity;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Temperature, Humidity);
//    }

//    public static bool operator ==(WeatherData? left, WeatherData? right)
//    {
//        return EqualityComparer<WeatherData>.Default.Equals(left, right);
//    }

//    public static bool operator !=(WeatherData? left, WeatherData? right)
//    {
//        return !(left == right);
//    }
