
using System.Globalization;

var point = new Point(10, 20);
//point.X++;
//MoveToRightBy1Unit(point);



var anotherPoint = point;
//anotherPoint.Y = 100;

Console.WriteLine("point is: " + point);
Console.WriteLine("anotherPoint is: " + anotherPoint);

SomeMethodVal(5);
SomeMethodRef(new Person());


//Point nullPoint = null;
Person nullPerson = null;

var person = new Person();
var point1 = new Point();

var fishyStruct1 = new FishyStruct { Numbers = new List<int> { 1, 2, 3 } };
var fishyStruct2 = fishyStruct1;
fishyStruct2.Numbers.Clear();

var dateTime = new DateTime(2023, 6, 7);
var dateWeekAfter = dateTime.AddDays(7);

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

struct Point(int x, int y)
{
    public int X { get; init; } = x; //inmutable struct 
    public int Y { get; init; } = y;

    //~Point()
    //{

    //}

    public override string ToString() => $"X: {X}, Y: {Y}";
}

class Person
{
    private Point _favouritePoint;
    private Person _favouritePerson;
    public int Id { get; init; }
    public string Name { get; init; }

    //public Person(int id, string name)
    //{
    //    Id = id;
    //    Name = name;
    //}
}