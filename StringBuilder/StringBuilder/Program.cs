using System.Diagnostics;
using System.Text;


const int Count = 200_000;
var text = string.Empty;
Stopwatch stopwatch = Stopwatch.StartNew();
for (int i = 0; i < Count; i++)
{
    text += "a";
}
stopwatch.Stop();
Console.WriteLine($"Concatenation took {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Restart();
var stringBuilder = new StringBuilder();
for (int i = 0; i < Count; i++)
{
    stringBuilder.Append("a");
}
stopwatch.Stop();
var text2 = stringBuilder.ToString();
Console.WriteLine($"StringBuilder took {stopwatch.ElapsedMilliseconds} ms");

Console.ReadKey();