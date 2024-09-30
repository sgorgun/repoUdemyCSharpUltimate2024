

Console.ReadKey();

void OddClassInit_ShallThrowExceptionWhenGivenNull()
{
    //validate this line throw an exception
    new OddClass().Init(null!);
}

public class OddClass
{
    public string? Text { get; private set; }
    private bool _isInitiated;

    public void Init(string text)
    {
        Text = text ?? throw new NullReferenceException(nameof(text));
        _isInitiated = true;
    }

    public void DoWork()
    {
        if (!_isInitiated)
        {
            throw new InvalidOperationException("The class sis not initialised");
        }

        Console.WriteLine("The length of text is: " + Text!.Length); // null forgiving operator
    }
}