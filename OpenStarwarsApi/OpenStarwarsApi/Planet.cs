
public readonly record struct Planet
{
    public string Name { get;  }
    public int Diameter { get; }
    public int? SurfaceWater { get; }
    public int? Population { get; }

    public Planet(string name, int diameter, int? surfaceWater, int? population)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Diameter = diameter;
        SurfaceWater = surfaceWater;
        Population = population;
    }
}