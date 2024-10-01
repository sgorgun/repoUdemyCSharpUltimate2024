
using OpenStarwarsApi.DTOs;

public readonly record struct Planet
{
    public string Name { get; }//can't be null
    public int Diameter { get; }//can't be null
    public int? SurfaceWater { get; } //can be null
    public int? Population { get; } // can be null

    public Planet(string name, int diameter, int? surfaceWater, int? population)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Diameter = diameter;
        SurfaceWater = surfaceWater;
        Population = population;
    }

    public static explicit operator Planet(Result planetDTO)
    {
        var name = planetDTO.Name;
        int diameter = int.Parse(planetDTO.Diameter);
        
        int? population = planetDTO.Population.ToIntOrNull();
        
        int? surfaceWater = planetDTO.SurfaceWater.ToIntOrNull();

        return new Planet(name, diameter, surfaceWater, population);
    }
}
