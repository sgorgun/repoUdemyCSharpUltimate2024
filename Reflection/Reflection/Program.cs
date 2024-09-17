using System.Xml.Linq;

var converter = new ObjectToTextConverter();
Console.WriteLine(converter.Convert(new House("123 Maple Road", 170.6, 2)));

class ObjectToTextConverter
{
    public string Convert(object obj)
    {
        Type type = obj.GetType();
        var properties = type
            .GetProperties()
            .Where(p => p.Name != "EqualityContract");

        return String.Join(", ", properties
            .Select(p => $"{p.Name} is {p.GetValue(obj)}"));
    }
}

public record Pet(string Name, PetType PetType, float Weight);
public record House(string Address, double Area, int Floors);
public enum PetType { Cat, Dog, Fish };