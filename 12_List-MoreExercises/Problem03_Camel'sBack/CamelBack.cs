using System;
using System.Collections.Generic;
using System.Linq;

class CamelBack
{
    static void Main()
    {
        string sequenceOfNumbers = Console.ReadLine(); // for buildings

        int camelBack = int.Parse(Console.ReadLine());
        List<string> buildings = sequenceOfNumbers.Split(' ').ToList();

        int rounds = (buildings.Count - camelBack) / 2;

        buildings = BuildingsAfterBreaking(camelBack, buildings, rounds);

        PrintHowManyRounds(rounds);
        PrintBuildingsAfterBreaking(buildings);
    }

    public static void PrintBuildingsAfterBreaking(List<string> buildings)
    {
        for (int i = 0; i < buildings.Count; i++)
        {
            Console.Write(buildings[i] + " ");
        }
    }

    public static void PrintHowManyRounds(int rounds)
    {
        if (rounds != 0)
        {
            Console.WriteLine($"{rounds} rounds");
            Console.Write("remaining: ");
        }

        else
        {
            Console.Write("already stable: ");
        }
    }

    public static List<string> BuildingsAfterBreaking(int camelBack, List<string> buildings, int rounds)
    {
        for (int i = 0; i < rounds; i++)
        {
            buildings.RemoveAt(0);
            buildings.RemoveAt(buildings.Count - 1);
        }
        return buildings;
    }
}

