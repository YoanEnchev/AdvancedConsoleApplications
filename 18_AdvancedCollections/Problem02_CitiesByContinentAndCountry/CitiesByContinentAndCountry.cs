using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CitiesByContinentAndCountry
{
    static void Main()
    {
        int howMany = int.Parse(Console.ReadLine());
        var data = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < howMany; i++)
        {
            string[] continentCountryCity = Console.ReadLine().Split(' ');
            data = AddData(continentCountryCity, data);
        }

        PrintData(data);
    }

    public static void PrintData(Dictionary<string, Dictionary<string, List<string>>> data)
    {
        foreach (var countinentsAndContries in data)
        {
            var continentName = countinentsAndContries.Key;
            var countryAndCities = countinentsAndContries.Value;

            Console.WriteLine(continentName + ":");

            foreach (var kvp in countryAndCities)
            {
                string cities = string.Join(", ", kvp.Value);
                Console.WriteLine("  " + kvp.Key + " -> " + cities);
            }
        }
    }

    public static Dictionary<string, Dictionary<string, List<string>>> AddData(string[] continentCountryCity, Dictionary<string, Dictionary<string, List<string>>> data)
    {
        string continent = continentCountryCity[0];
        string country = continentCountryCity[1];
        string city = continentCountryCity[2];

        if (!data.ContainsKey(continent))
        {
            data[continent] = new Dictionary<string, List<string>>();
        }

        if (!data[continent].ContainsKey(country))
        {
            data[continent][country] = new List<string>();
        }

        data[continent][country].Add(city);

        return data;
    }
}

