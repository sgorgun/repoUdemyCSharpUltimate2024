var countryToCurrencyMapping = new Dictionary<string, string>
{
    ["USA"] = "USD",
    ["India"] = "INR",
    ["Spain"] = "EUR",

};

//countryToCurrencyMapping.Add("USA", "USD");
//countryToCurrencyMapping.Add("India", "INR");
//countryToCurrencyMapping.Add("Spain", "EUR");

//Console.WriteLine("Currency in Spain is " +
//    countryToCurrencyMapping["Spain"]);

countryToCurrencyMapping["Poland"] = "PLN";
countryToCurrencyMapping["Poland"] = "EUR";

//Console.WriteLine("Currency in Poland is " +
//    countryToCurrencyMapping["Poland"]);

//if (countryToCurrencyMapping.ContainsKey("Italy"))
//{
//    Console.WriteLine("Currency in Italy is " +
//    countryToCurrencyMapping["Italy"]);
//}

foreach (var item in countryToCurrencyMapping)
{
    Console.WriteLine($"Currency in {item.Key} is " + $"{item.Value}");
}

Console.ReadKey();