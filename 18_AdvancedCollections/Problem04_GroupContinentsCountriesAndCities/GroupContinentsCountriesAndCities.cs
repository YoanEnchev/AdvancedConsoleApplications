using System;
using System.Collections.Generic;
using System.Linq;

class GroupContinentsCountriesAndCities
{
    static void Main()
    {
        int howMany = int.Parse(Console.ReadLine());
        var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

        for (int i = 0; i < howMany; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            data = AddData(data, tokens);
        }

        PrintData(data);
    }

    public static void PrintData(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> data)
    {
        foreach (var kvp in data)
        {
            string continentName = kvp.Key;
            var countriesAndCities = kvp.Value;
            Console.WriteLine(continentName + ":");

            foreach (var item in countriesAndCities)
            {
                Console.WriteLine($"  {item.Key} -> {string.Join(", ",item.Value)}");
            }
        }
    }

    public static SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> AddData(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> data, string[] tokens)
    {
        string continent = tokens[0];
        string country = tokens[1];
        string city = tokens[2];

        if (!data.ContainsKey(continent))
        {
            data[continent] = new SortedDictionary<string, SortedSet<string>>();
        }

        if (!data[continent].ContainsKey(country))
        {
            data[continent][country] = new SortedSet<string>();
        }

        data[continent][country].Add(city);
        return data;
    }
}

