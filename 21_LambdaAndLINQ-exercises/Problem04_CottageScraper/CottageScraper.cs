using System;
using System.Collections.Generic;
using System.Linq;

public class CottageScraper
{
    public static void Main()
    {
        string input = Console.ReadLine();
        List<string> woodType = new List<string>();
        List<int> height = new List<int>();

        while (input != "chop chop")
        {
            string[] woodAndQuantity = input.Split(' ');

            woodType.Add(woodAndQuantity[0]);
            height.Add(int.Parse(woodAndQuantity[2]));

            input = Console.ReadLine();
        }

        string neededType = Console.ReadLine();
        int minimumLength = int.Parse(Console.ReadLine());

        decimal pricePerMeter = (decimal)height.Sum() / height.Count;
        pricePerMeter = Math.Round(pricePerMeter, 2);

        int[] sumOfHeightsOfUnsusableAndUsableTrees = GetSumOfHeightOfThreesThatWillBeUsedAndOfUnusableThrees(woodType, height, neededType, minimumLength);

        int sumOfUsables = sumOfHeightsOfUnsusableAndUsableTrees[0];
        int sumOfUnusables = sumOfHeightsOfUnsusableAndUsableTrees[1];

        decimal usedLogsPrice = sumOfUsables * pricePerMeter;
        usedLogsPrice = Math.Round(usedLogsPrice, 2);

        decimal unusedLogsPrice = sumOfUnusables * pricePerMeter *1 / 4;
        unusedLogsPrice = Math.Round(unusedLogsPrice, 2);

        decimal subtotal =  usedLogsPrice + unusedLogsPrice;
        subtotal = Math.Round(subtotal, 2);

        PrintResult(pricePerMeter,usedLogsPrice, unusedLogsPrice, subtotal);
    }

    public static void PrintResult(decimal pricePerMeter, decimal usedLogsPrice, decimal unusedLogsPrice, decimal subtotal)
    {
        Console.WriteLine($"Price per meter: ${pricePerMeter}");
        Console.WriteLine($"Used logs price: ${usedLogsPrice}");
        Console.WriteLine($"Unused logs price: ${unusedLogsPrice}");
        Console.WriteLine($"CottageScraper subtotal: ${subtotal}");
    }

    public static int[] GetSumOfHeightOfThreesThatWillBeUsedAndOfUnusableThrees(List<string> woodType, List<int> height,
        string neededType, int minimumLength)
    {
        var heightOfUsableAndUnusables = new int[2];

        List<int> HeightOfTreesThatWillBeUsed = new List<int>();
        List<int> HeightOfUnusableThrees = new List<int>();

        for (int i = 0; i < woodType.Count; i++)
        {
            if (woodType[i] == neededType && height[i] > minimumLength)
            {
                HeightOfTreesThatWillBeUsed.Add(height[i]);
            }

            else
            {
                HeightOfUnusableThrees.Add(height[i]);
            }
        }

        heightOfUsableAndUnusables[0] = HeightOfTreesThatWillBeUsed.Sum();
        heightOfUsableAndUnusables[1] = HeightOfUnusableThrees.Sum();
        return heightOfUsableAndUnusables;
    }
}

