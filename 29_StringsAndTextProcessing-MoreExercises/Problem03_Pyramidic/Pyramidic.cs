using System;
using System.Collections.Generic;
using System.Linq;

class Pyramidic
{
    static void Main(string[] args)
    {
        int howManyRows = int.Parse(Console.ReadLine());
        var allSymbols = new HashSet<char>();

        var symbolAndPyramidIndex = new Dictionary<char, int>();

        var rows = new List<string>();

        for (int i = 0; i < howManyRows; i++)
        {
            string row = Console.ReadLine();
            rows.Add(row);

            allSymbols = AddSymbolsFromCurrentRow(row, allSymbols);
        }

        List<char> symbols = allSymbols.ToList();

        for (int s = 0; s < symbols.Count; s++)
        {
            char symbol = symbols[s];
            int pyramidBase = 1;
            int pyramidIndex = 0;
            int largestPyramidIndex = -1;

            for (int i = 0; i < rows.Count; i++)
            {
                string row = rows[i];

                if (row.Contains(new string(symbol, pyramidBase)))
                {
                    pyramidIndex++;
                    pyramidBase++;
                }

                else
                {
                    pyramidIndex = 0;
                    pyramidBase = 1;
                }

                if (pyramidIndex > largestPyramidIndex)
                {
                    largestPyramidIndex = pyramidIndex;
                }
            }

            symbolAndPyramidIndex[symbol] = largestPyramidIndex;
        }
        Dictionary<char, int> highestPyramidIndex = GetHighestPyramidIndex(symbolAndPyramidIndex);

        int index = 0;
        char symbol_highestIndex = ' ';

        foreach (var kvp in highestPyramidIndex)
        {
            index = kvp.Value;
            symbol_highestIndex = kvp.Key;
        }

        PrintResult(index, symbol_highestIndex);
    }

    public static void PrintResult(int index, char symbol)
    {
        int howManySymbolsOnLine = 1;

        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(new string(symbol, howManySymbolsOnLine));

            howManySymbolsOnLine += 2;
        }
    }

    public static Dictionary<char, int> GetHighestPyramidIndex(Dictionary<char, int> symbolAndPyramidIndex)
    {
        symbolAndPyramidIndex = symbolAndPyramidIndex
            .OrderByDescending(x => x.Value)
            .ToDictionary(y => y.Key, z => z.Value);

       var charAndhighestPyramidIndex = new Dictionary<char, int>();

        foreach (var kvp in symbolAndPyramidIndex)
        {
            charAndhighestPyramidIndex[kvp.Key] = kvp.Value;
            break;
        }
        return charAndhighestPyramidIndex;
    }

    public static HashSet<char> AddSymbolsFromCurrentRow(string row, HashSet<char> allSymbols)
    {
        for (int i = 0; i < row.Length; i++)
        {
            char symbol = row[i];
            allSymbols.Add(symbol);
        }

        return allSymbols;
    }
}

