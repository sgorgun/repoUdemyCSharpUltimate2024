Print print1 = text => Console.WriteLine(text.ToUpper());
Print print2 = text => Console.WriteLine(text.ToLower());
Print multicast = print1 + print2;
Print print3 = text => Console.WriteLine(text.Substring(0, 3));
multicast += print3;
multicast("Crocodile");

Func<string, string, int> sumLengths = SumLenghts;

Console.ReadKey();

int SumLenghts(string text1, string text2)
    => text1.Length + text2.Length;

delegate void Print(string input);
