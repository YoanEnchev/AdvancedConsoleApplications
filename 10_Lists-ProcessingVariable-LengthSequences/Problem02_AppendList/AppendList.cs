using System;
using System.Collections.Generic;
using System.Linq;

class AppendList
{
    static void Main()
    {
        List<string> sequences = Console.ReadLine().Split('|').ToList();

        string PartOfTheSequence = "";
        string result = "";

        for (int i = sequences.Count - 1; i >= 0; i--)
        {
            PartOfTheSequence = sequences[i];

            PartOfTheSequence = EliminateNotNeededSpaces(PartOfTheSequence);

            result += PartOfTheSequence;
        }
        Console.WriteLine(result);
    }

    public static string EliminateNotNeededSpaces(string partOfTheSequence)
    {
        string Reformated = "";
        for (int i = 0; i < partOfTheSequence.Length; i++)
        {
            char symbol = partOfTheSequence[i];
            if (symbol != ' ')
            {
                Reformated += partOfTheSequence[i] + " ";
            }
        }
        return Reformated;
    }
}

