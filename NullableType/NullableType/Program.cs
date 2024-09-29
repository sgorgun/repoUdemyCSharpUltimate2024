string text = null;

int? numberOrNull = null;
Nullable<bool> boolOrNull = true;

var heights = new List<Nullable<int>>
{
    160, null, 185, null, 170
};

var averagHeight = heights
    .Average();

Console.WriteLine("Averrage height is " + averagHeight);

if(numberOrNull.HasValue)
{
    int number = numberOrNull.Value;
    Console.WriteLine("Not null");
}

if (boolOrNull.HasValue)
{
    var someBool = boolOrNull.Value;
    Console.WriteLine(someBool);
}

Console.ReadKey();