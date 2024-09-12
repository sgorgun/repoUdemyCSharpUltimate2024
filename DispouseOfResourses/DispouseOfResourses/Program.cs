﻿const string filePath = "file.txt";
using (var writer = new FileWriter(filePath))
{
    writer.Write("some text");
    writer.Write("some other text");
}

using var reader = new SpecificLineFromTextReader(filePath);
var third = reader.ReadLineNumber(3);
var fourth = reader.ReadLineNumber(4);

Console.WriteLine("Third line is: " + third);
Console.WriteLine("Fourth line is: " + fourth);

Console.WriteLine("Press any key for close.");
Console.ReadKey();

public class FileWriter : IDisposable
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

    public void Dispose()
    {
        _streamWriter.Dispose();
    }
}

public class SpecificLineFromTextReader : IDisposable
{
    private readonly StreamReader _streamReader;
    public SpecificLineFromTextReader(string filePath)
    {
        _streamReader = new StreamReader(filePath);
    }

    public string ReadLineNumber(int lineNumber)
    {
        _streamReader.DiscardBufferedData(); //clear buffer
        _streamReader.BaseStream.Seek(0, SeekOrigin.Begin);// move reader in the begining
        
        for (int i = 0; i < lineNumber - 1; i++)
        {
            _streamReader.ReadLine();
        }

        return _streamReader.ReadLine();
    }
    public void Dispose()
    {
        _streamReader.Dispose();
    }
}