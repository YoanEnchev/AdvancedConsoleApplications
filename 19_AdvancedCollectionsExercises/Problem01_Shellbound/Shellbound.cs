using System;
using System.Collections.Generic;
using System.Linq;

class Shellbound
{
    static void Main()
    {
        string[] regionAndSize = Console.ReadLine().Split(' ');
        var regionsAndSizes = new Dictionary<string, HashSet<long>>();

        while (regionAndSize[0] != "Aggregate")
        {
            string region = regionAndSize[0];
            long size = long.Parse(regionAndSize[1]);
            regionAndSize = Console.ReadLine().Split(' ');
            regionsAndSizes = AddData(region, size, regionsAndSizes);
        }

        PrintData(regionsAndSizes);
    }

    public static void PrintData(Dictionary<string, HashSet<long>> regionsAndSizes)
    {
        foreach (var kvp in regionsAndSizes)
        {
            long sum = 0;
            int countOfHashset = 0;
            Console.Write(kvp.Key + " -> ");
            Console.Write(string.Join(", ", kvp.Value));

            foreach (var elementOfHashSet in kvp.Value)
            {
                sum += elementOfHashSet;
                countOfHashset++;
            }
            Console.WriteLine($" ({sum - (sum / countOfHashset)})");
        }
    }

    public static Dictionary<string, HashSet<long>> AddData(string region, long size, Dictionary<string, HashSet<long>> regionsAndSizes)
    {
        if (!regionsAndSizes.ContainsKey(region))
        {
            regionsAndSizes[region] = new HashSet<long>();
        }

        regionsAndSizes[region].Add(size);
        return regionsAndSizes;
    }
}

