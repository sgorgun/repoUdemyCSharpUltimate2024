var point = new Point(1, 3);
var anotherPoint = point;
anotherPoint.Y = 100;

Console.WriteLine("point is: " + point);
Console.WriteLine("anotherPoint is: " + anotherPoint);

SomeMethodVal(5);
SomeMethodRef(new Person());

Console.ReadKey();

void SomeMethodVal<T>(T param) where T : struct
{

}

void SomeMethodRef<T>(T param) where T : class
{

}

struct Point(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public override string ToString() => $"X: {X}, Y: {Y}";
}

class Person
{
    public int Id { get; init; }
    public string Name { get; init; }
}