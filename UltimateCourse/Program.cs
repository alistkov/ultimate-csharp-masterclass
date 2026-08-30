var countryToCurrencyMapping = new Dictionary<string, string>();

countryToCurrencyMapping.Add("USA", "USD");
countryToCurrencyMapping.Add("India", "INR");
countryToCurrencyMapping.Add("Spain", "EUR");
countryToCurrencyMapping.Add("Serbia", "RSD");
countryToCurrencyMapping["Poland"] = "PLN";

foreach (var country in countryToCurrencyMapping)
{
    Console.WriteLine($"Country: {country.Key}, currency: {country.Value}");
}