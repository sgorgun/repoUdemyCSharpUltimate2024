var test = new TestStruct
{
    Text = "abc"
};

var other = test; //with strings it work because strings are immutable.

Console.ReadKey();

public struct TestStruct
{
    public string Text { get; init; }
}