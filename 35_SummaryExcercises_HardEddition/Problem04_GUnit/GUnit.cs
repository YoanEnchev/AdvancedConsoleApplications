using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class GUnit
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"^[A-Z][a-z0-9A-Z]+ \| [A-Z][a-z0-9A-Z]+ \| [A-Z][a-z0-9A-Z]+$";
        var data = new Dictionary<string, Dictionary<string, HashSet<string>>>();

        while (input != "It's testing time!")
        {
            bool inputIsValid = Regex.IsMatch(input, pattern);

            if (inputIsValid)
            {
                string[] tokens = input.Split(new[] { " | " }, StringSplitOptions.None).ToArray();

                string className = tokens[0];
                string metodName = tokens[1];
                string testName = tokens[2];

                if (!data.ContainsKey(className))
                {
                    data[className] = new Dictionary<string, HashSet<string>>();
                }

                if (!data[className].ContainsKey(metodName))
                {
                    data[className][metodName] = new HashSet<string>();
                }

                data[className][metodName].Add(testName);
            }
            input = Console.ReadLine();
        }
        SortAndPrintResult(data);
    }

    public static void SortAndPrintResult(Dictionary<string, Dictionary<string, HashSet<string>>> data)
    {
        data = data
            .OrderByDescending(x => x.Value.Values.Sum(y => y.Count))
            .ThenBy(x => x.Value.Count)
            .ThenBy(x => x.Key)
            .ToDictionary(y => y.Key, z => z.Value);

        foreach (var kvp in data)
        {
            var className = kvp.Key;
            var metodsAndTests = kvp.Value
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(y => y.Key, z => z.Value);

            Console.WriteLine($"{className}:");

            foreach (var metodAndTests in metodsAndTests)
            {
                string metodName = metodAndTests.Key;
                List<string> tests = metodAndTests.Value
                    .OrderBy(x => x.Length)
                    .ThenBy(x => x, StringComparer.Ordinal)
                    .ToList();

                Console.WriteLine($"##{metodName}");

                foreach (var test in tests)
                {
                    Console.WriteLine($"####{test}");
                }
            }
        }
    }
}

