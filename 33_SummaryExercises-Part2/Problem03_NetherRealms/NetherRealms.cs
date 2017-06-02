using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class NetherRealms
{
    static void Main()
    {
        List<string> names = Console.ReadLine()
        .Split(',')
        .Select(name => name.Trim())
        .ToList();

        string pattern_demonHealth = @"[^\+\-\*\/\.\d]";
        string pattern_numbers = @"[\+\-]*[0-9.]+[0-9]*";

        List<Demon> demonsInfo = new List<Demon>();

        for (int i = 0; i < names.Count; i++)
        {
            string name = names[i];

            MatchCollection healthCharacters_matches = Regex.Matches(name, pattern_demonHealth);
            List<string> healthCharacters = ConvertToList(healthCharacters_matches);

            MatchCollection numbers_matches = Regex.Matches(name, pattern_numbers);
            List<double> numbers = ConvertToList(numbers_matches)
                .Select(x => double.Parse(x))
                .ToList();
         
            int health = GetHealth(healthCharacters);
            double damage = numbers.Sum();
            damage = MultiplyAndDivide(damage, name);

            Demon currentDemon = new Demon
            {
                name = name,
                health = health,
                damage = damage
            };

            demonsInfo.Add(currentDemon);
        }
    
        SortAndPrintResult(demonsInfo);
    }

    public static double MultiplyAndDivide(double damage, string name)
    {
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == '*')
            {
                damage *= 2;
            }

            if (name[i] == '/')
            {
                damage /= 2;
            }
        }

        return damage;
    }

    public static void SortAndPrintResult(List<Demon> demonsInfo)
    {
        demonsInfo = demonsInfo
            .OrderBy(x => x.name)
            .ToList();

        for (int i = 0; i < demonsInfo.Count; i++)
        {
            Demon demon = demonsInfo[i];

            Console.WriteLine($"{demon.name} - {demon.health} health, {demon.damage:F2} damage");
        }
    }

    public static int GetHealth(List<string> healthCharacters)
    {
        int sumOfCharacters = 0;

        for (int i = 0; i < healthCharacters.Count; i++)
        {
            string symbol = healthCharacters[i];
            sumOfCharacters += symbol[0];
        }

        return sumOfCharacters;
    }

    public static List<string> ConvertToList(MatchCollection collection)
    {
        var list = new List<string>();

        for (int i = 0; i < collection.Count; i++)
        {
            list.Add(collection[i].ToString());
        }

        return list;
    }
}

