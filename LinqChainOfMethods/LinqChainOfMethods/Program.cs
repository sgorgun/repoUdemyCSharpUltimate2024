var numbers = new List<int> { 5, 3, 7, 1, 2, 4 };
var numbersWith10 = numbers.Append(10);

Console.WriteLine("Numbers: " + string.Join(", ", numbers));
Console.WriteLine("Numbers with 10: " + string.Join(", ", numbersWith10));

//var oddNumbers = numbers.Where(number => number % 2 == 1);
var orderedOddNumberers = numbers
    .Where(number => number % 2 == 1)
    .OrderBy(number => number);

//Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
Console.WriteLine("Odered odd numbers: " + string.Join(", ", orderedOddNumberers));

Console.ReadKey();