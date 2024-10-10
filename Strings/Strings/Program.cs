using System.Text;

//Console.OutputEncoding = Encoding.Unicode;
char greek = 'Ω';
char arabic = 'ػ';
char symbol = '!';
Console.WriteLine(greek);
Console.WriteLine(arabic);
Console.WriteLine(Console.OutputEncoding);

string text = "abc";
text += "d";
Console.WriteLine(text);

var upperCase = text.ToUpper();
Console.WriteLine(upperCase);

string text1 = "abc";
string text2 = "abc";
Console.WriteLine(text1.Equals(text2));
Console.WriteLine(text1 == text2);
Modify(text1);
Console.WriteLine(text1);

Console.ReadKey();

void Modify (string input)
{
    input += "xyz";
}