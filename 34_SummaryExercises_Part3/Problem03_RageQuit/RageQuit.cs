using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

class RageQuit
{
    static void Main()
    {
        string input = Console.ReadLine().ToUpper();
        string pattern = @"([^\d]+)([0-9]+)";

        StringBuilder ragequitMessage = new StringBuilder();
        MatchCollection ragequitInstructions = Regex.Matches(input, pattern);

        foreach (Match match in ragequitInstructions)
        {
            string toBeRepeated = match.Groups[1].Value;
            int howManyTimes = int.Parse(match.Groups[2].Value);

            ragequitMessage.Append(RepeatSymbols(toBeRepeated, howManyTimes));
        }

        int uniqueSymbols = ragequitMessage.ToString().Distinct().Count();

        Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
        Console.WriteLine(ragequitMessage);
    }

    public static string RepeatSymbols(string toBerepeated, int howManyTimes)
    {
        StringBuilder add = new StringBuilder();

        for (int i = 0; i < howManyTimes; i++)
        {
            add.Append(toBerepeated);
        }

        return add.ToString();
    }
}

