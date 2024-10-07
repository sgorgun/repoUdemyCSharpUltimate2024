var hashSet = new HashSet<string>();
hashSet.Add("aaa");
hashSet.Add("aaa");
hashSet.Add("bbb");

Console.ReadKey();

public class SpellChecker
{
    private readonly HashSet<string> _correctWords = new()
    {
        "dog", "cat", "fish"
    };

    public bool IsCorrect(string word) =>
        _correctWords.Contains(word);
    public void AddCorrectWord(string word) =>
        _correctWords.Add(word);
}
