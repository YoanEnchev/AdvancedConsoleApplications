using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

    class Cards
    {
        static void Main()
        {
        string input = Console.ReadLine().Trim();
        string pattern = @"(10|[2-9]|J|Q|K|A)(S|H|C|D)";

        MatchCollection matches = Regex.Matches(input, pattern);
        List<string> matches_List = ConvertToList(matches);

        Console.WriteLine(string.Join(", ", matches_List));
        }

    public static List<string> ConvertToList(MatchCollection matches)
    {
        List<string> matches_List = new List<string>();

        for (int i = 0; i < matches.Count; i++)
        {
            matches_List.Add(matches[i].ToString());
        }

        return matches_List;
    }
}

