using System.Collections;

var customCollection = new CustomCollection(
    new string[] { "aaa", "bbb", "ccc" });
var enumerator = customCollection.GetEnumerator();

foreach (var item in customCollection)
{
    Console.WriteLine(item);
}

var numbers = new List<int> { 1, 2, 3, 4, 5 };
var array = new int[10];
numbers.CopyTo(array, 2);

var numbers2 = new List<int>(new int[] { 1, 2, 3 }); // init list with array

var array2 = new int[] { 1, 2, 3 };
var implementedInterfaces = array.GetType().GetInterfaces();

ICollection<int> arrayAsCollection = array; // Array under the hud.
//arrayAsCollection.Add(4); // it don't make sence. And it don't compile

Console.ReadKey();

public class CustomCollection : IEnumerable<string>
{
    public string[] Words { get; }


    public CustomCollection(string[] words)
    {
        Words = words;
    }

    public string this[int index]
    {
        get => Words[index];
        set => Words[index] = value;
    }

    IEnumerator IEnumerable.GetEnumerator() //expisit interface. Can't be public
    {
        return GetEnumerator();
    }

    public IEnumerator<string> GetEnumerator() //impicit inteface
    {
        //return new WordsEnumerator(Words);
        foreach (var word in Words) // yield iterator is implemented
        {
            yield return word;
        }
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