var test = new TestStruct
{
    List = new List<int> { 1, 2, 3 }
};

var other = test; //it's copy link. It's unexpected behavior from structure. 
other.List.Clear();

Console.ReadKey();

public struct TestStruct
{
    public List<int> List { get; init; }
}