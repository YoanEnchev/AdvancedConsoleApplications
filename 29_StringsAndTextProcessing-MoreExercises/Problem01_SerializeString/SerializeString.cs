using System;
using System.Collections.Generic;

class SerializeString
{
    static void Main()
    {
        string input = Console.ReadLine();
        var symbolAndPositions = new Dictionary<char, List<int>>();

        for (int i = 0; i < input.Length; i++)
        {
            char symbol = input[i];
            List<int> positions = new List<int>();

            for (int p = 0; p < input.Length; p++)
            {
                if (input[i] == input[p])
                {
                    positions.Add(p);
                }
                symbolAndPositions[symbol] = positions;
            }
        }

        PrintResult(symbolAndPositions);
    }

    public static void PrintResult(Dictionary<char, List<int>> symbolAndPositions)
    {
        foreach (var kvp in symbolAndPositions)
        {
            Console.WriteLine($"{kvp.Key}:{string.Join("/", kvp.Value)}");
        }
    }
}

