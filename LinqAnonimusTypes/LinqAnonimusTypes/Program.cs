var listsNumbers = new List<List<int>>
{
    new List<int> { 15, 68, 20, 12, 19, 8, 55 },
    new List<int> { 12, 1, 3, 4, -19, 8, 7, 6 },
    new List<int> { 5, -6, -2, -12, -10, 7 },
};

var result = listsNumbers
    .Select(listsNumbers => new Tuple<int, double>
    (
        listsNumbers.Count(),
        listsNumbers.Average()
    ))
    .OrderByDescending(countAndAverage => countAndAverage.Item2)
    .Select(countAndAverage =>
        $"Count is: {countAndAverage.Item1}, " +
        $"Average is: {countAndAverage.Item2}");

Console.WriteLine(string.Join(Environment.NewLine, result));

Console.ReadKey();