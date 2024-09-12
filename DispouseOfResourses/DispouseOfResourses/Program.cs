const string filePath = "file.txt";
var writer = new FileWriter(filePath);
writer.Write("some text");
writer.Write("some other text");

Console.WriteLine("Press any key for close.");
Console.ReadKey();

public class FileWriter
{
    public readonly StreamWriter _streamWriter;
    public FileWriter(string filePath)
    {
        _streamWriter = new StreamWriter(filePath, true);
    }
    public void Write(string text)
    {
        _streamWriter.WriteLine(text);
        _streamWriter.Flush();
    }
}