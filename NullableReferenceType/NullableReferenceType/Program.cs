class Program
{
    static void Main(string[] args)
    {
        string? nonNulableString = null;
        Console.WriteLine(nonNulableString);
        var house = new House("Owner", new Address("Street", "house"));
    }

    static int GetLength(string? nullableText)
    {
        if (nullableText == null)
        {
            throw new ArgumentNullException(nameof(nullableText));
        }

        return nullableText.Length;
    }

    string FormatHousesData(IEnumerable<House> houses)
    {
        return string.Join("\n",
            houses.Select(house =>
            $"Owner is {house.OwnerName}, " +
            $"address is {house.Address.Number} " +
            $"{house.Address.Street}"));
    }
}

public class House
{
    public string OwnerName { get; }
    public Address Address { get; }

    public House(string ownerName, Address address)
    {
        if (ownerName == null)
        {
            throw new ArgumentNullException(nameof(ownerName));
        }
        if (address == null)
        {
            throw new ArgumentNullException(nameof(address));
        }
        OwnerName = ownerName;
        Address = address;
    }
}

public class Address
{
    public string Street { get; }
    public string Number { get; }

    public Address(string street, string number)
    {
        Street = street;
        Number = number;
    }
}