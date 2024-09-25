
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

//var point = new Point(10, 20);
////point.X++;
////MoveToRightBy1Unit(point);
//var pointMoved = point with { X = point.X + 1 };

//var pet = new { Name = "Hanibal", Type = "fish" }; // anonimus type whith nonedestructiwe mutation
//var asCrab = pet with { Type = "crab" };

//var anotherPoint = point;
////anotherPoint.Y = 100;

//Console.WriteLine("point is: " + point);
//Console.WriteLine("anotherPoint is: " + anotherPoint);

//SomeMethodVal(5);
////SomeMethodRef(new Person());


////Point nullPoint = null;
//Person nullPerson = null;

////var person = new Person();
//var point1 = new Point();

//var fishyStruct1 = new FishyStruct { Numbers = new List<int> { 1, 2, 3 } };
//var fishyStruct2 = fishyStruct1;
//fishyStruct2.Numbers.Clear();

//var dateTime = new DateTime(2023, 6, 7);
//var dateWeekAfter = dateTime.AddDays(7);

//var john = new Person(1, "John");
//var theSameAsJohn = new Person(1, "John");
//var asJohn = john;
//Console.WriteLine("Are reference equal? " +
//    object.ReferenceEquals(john, theSameAsJohn));
//Console.WriteLine("Are reference equal? " +
//    object.ReferenceEquals(john, asJohn)); 

//Console.WriteLine(object.ReferenceEquals(1, 1)); //Value
//Console.WriteLine(object.ReferenceEquals(null, null));

//Console.WriteLine("1.Equals(1): " + 1.Equals(1));
//Console.WriteLine("1.Equals(2): " + 1.Equals(2));
//Console.WriteLine("1.Equals(null): " + 1.Equals(null));
//Console.WriteLine("\"abc\".Equals(\"abc\"): " + "abc".Equals("abc"));
//Console.WriteLine();

var point1 = new Point(1, 5);
var point2 = new Point(2, 4);
var added = point1 + point2;

Console.WriteLine("point1 == point2: " + (point1 == point2));

//Console.WriteLine("point1.Equals(point2): " + point1.Equals(point2));
//Console.WriteLine();

//var john = new Person(1, "John");
//var theSameAsJohn = new Person(1, "John");
//var marie = new Person(2, "Marie");

//Console.WriteLine("john.Equals(theSameAsJohn): " + john.Equals(theSameAsJohn));
//Console.WriteLine("john.Equals(marie): " + john.Equals(marie));
//Console.WriteLine("john.Equals(null): " + john.Equals(null));

int tenAsInt = 10;
decimal tenAsDecimal = tenAsInt;
 
decimal someDecimal = 20.01m;
int someInt = (int)someDecimal;

var tuple = Tuple.Create(10, 20);
Point point = tuple; 

Console.ReadKey();

//void MoveToRightBy1Unit(Point point)
//{
//    point.X++;
//}

void SomeMethodVal<T>(T param) where T : struct
{

}

void SomeMethodRef<T>(T param) where T : class
{

}

struct FishyStruct
{
    public List<int> Numbers { get; init; }
}

readonly struct Point(int x, int y) : IEquatable<Point> //The better if struct to be readonly
{
    public int X { get; init; } = x; //inmutable struct 
    public int Y { get; init; } = y;

    public bool Equals(Point other) // more specialised/ Will be used first. Without boxing
    {
        return X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj) // less specialised. Withh boxing.
    {
        return obj is Point point &&
               Equals(point);
    }

    //~Point()
    //{

    //}

    public override string ToString() => $"X: {X}, Y: {Y}";

    public static Point operator +(Point a, Point b) =>
        new Point(a.X + b.X, a.Y + b.Y);

    public static bool operator ==(Point point1, Point point2) =>
        point1.Equals(point2);
    public static bool operator !=(Point point1, Point point2) =>
        !point1.Equals(point2);
    public static implicit operator Point(Tuple<int, int> tuple) =>
        new Point(tuple.Item1, tuple.Item2); // or explisit
}

class Person
{
    private Point _favouritePoint;
    private Person _favouritePerson;
    public int Id { get; init; }
    public string Name { get; init; }

    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        return obj is Person other &&
            Id == other.Id;
    }
}