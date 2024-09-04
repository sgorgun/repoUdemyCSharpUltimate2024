var words = new List<string> { "a", "bb", "ccc", "dddd" };
var wordsLongerThan2Letters = words.Where(letter => letter.Count() > 2);
foreach (var word in wordsLongerThan2Letters)
{
    Console.WriteLine(word + " ");
}

var numbers = new int[] { 1, 2, 3, 4, 5, 6 };

var oddNumbers = numbers.Where(number => number % 2 == 1);
foreach (var number in oddNumbers)
{
    Console.WriteLine(number + " ");
}

Console.ReadKey();