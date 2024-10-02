using System.Collections;

//var text = "hello there";

//foreach(char character in text)
//{
//    Console.WriteLine(character);
//}

//var words = new string[] { "aaa", "bbb", "ccc" };

//IEnumerator wordsEnumerator = words.GetEnumerator();
//object currentWord;
//while(wordsEnumerator.MoveNext())
//{
//    currentWord = wordsEnumerator.Current;
//    Console.WriteLine(currentWord);
//}

var customCollection = new CustomCollection(
    new string[] { "aaa", "bbb", "ccc" });
var enumerator = customCollection.GetEnumerator();

foreach (var item in customCollection)
{
    Console.WriteLine(item);
}

Console.ReadKey();

public class CustomCollection : IEnumerable<string>
{
    public string[] Words { get; }

    public CustomCollection(string[] words)
    {
        Words = words;
    }

    IEnumerator IEnumerable.GetEnumerator() //expisit interface. Can't be public
    {
        return GetEnumerator();
    }
    
    public IEnumerator<string> GetEnumerator() //impicit inteface
    {
        return new WordsEnumerator(Words);
    }
}

public class WordsEnumerator : IEnumerator<string>
{
    private int _currentPosition = -1;
    private readonly string[] _words;

    public WordsEnumerator(string[] words)
    {
        _words = words;
    }

    object IEnumerator.Current => Current;

    public string Current
    {
        get
        {
            try
            {
                return _words[_currentPosition];
            }
            catch (IndexOutOfRangeException ex)
            {

                throw new IndexOutOfRangeException(
                    $"{nameof(CustomCollection)}'s end reached", ex);
            }
        }
    }

    public bool MoveNext()
    {
        ++_currentPosition;
        return _currentPosition < _words.Length;
    }

    public void Reset()
    {
        _currentPosition = -1;
    }

    public void Dispose()
    {

    }
}