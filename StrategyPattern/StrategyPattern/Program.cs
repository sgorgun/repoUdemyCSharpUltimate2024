var numbers = new List<int> { 10, 12, -100, 55, 17, 22 };
var filteringStrategySelector = new FilteringStrategySelector();

Console.WriteLine(@"Select filter:");
Console.WriteLine(string.Join(Environment.NewLine, filteringStrategySelector.FilteringStrategiesNames));

var userInput = Console.ReadLine();

var filteringStrategy = filteringStrategySelector.Select(userInput);
var result = new Filter().FilterBy(filteringStrategy, numbers);

Print(result);

var words = new[] { "zbra", "ostrish", "otter" };
var oWords = new Filter().FilterBy(word => word.StartsWith("o"), words);

Console.ReadKey();

void Print(IEnumerable<int> numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

public class FilteringStrategySelector //Implemented strategy pattern
{
    private readonly Dictionary<string, Func<int, bool>> filteringStrategies = new Dictionary<string, Func<int, bool>>
    {
        ["Even"] = number => number % 2 == 0,
        ["Odd"] = number => number % 2 == 1,
        ["Positive"] = number => number > 0,
        ["Negative"] = number => number < 0,
    };

    public IEnumerable<string> FilteringStrategiesNames => filteringStrategies.Keys;

    public Func<int, bool> Select(string filteringType)
    {
        if (!filteringStrategies.ContainsKey(filteringType))
        {
            throw new NotSupportedException($"{filteringType} is not a valid filter");
        }
        return filteringStrategies[filteringType];
    }
}

public class Filter
{
    public List<T> FilterBy<T>(Func<T, bool> predicate, IEnumerable<T> numbers)
    {
        var result = new List<T>();

        foreach (var number in numbers)
        {
            if (predicate(number))
            {
                result.Add(number);
            }
        }

        return result;
    }
}