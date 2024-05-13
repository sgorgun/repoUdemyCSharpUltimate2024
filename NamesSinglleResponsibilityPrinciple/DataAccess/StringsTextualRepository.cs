namespace NamesSinglleResponsibilityPrinciple.DataAccess;

class StringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;

    public List<string> Read(string filePath)
    {
        Console.WriteLine("Reding a file");
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Environment.NewLine).ToList();
    }

    public void Write(string filePath, List<string> strings) =>
        File.WriteAllText(filePath, string.Join(Environment.NewLine, strings));
}

