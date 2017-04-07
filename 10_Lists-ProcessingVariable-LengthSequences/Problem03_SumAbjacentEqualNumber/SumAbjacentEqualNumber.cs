using System;
using System.Collections.Generic;
using System.Linq;

class SumAbjacentEqualNumber
{
    static void Main()
    {
        string sequence = Console.ReadLine();

        List<string> numbers = new List<string>();
        numbers = sequence.Split(' ').ToList();

        List<int> sequenceOfNumbers = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            sequenceOfNumbers.Add(int.Parse(numbers[i]));
        }

        sequenceOfNumbers = SumTheAbjacents(sequenceOfNumbers);

        PrintTheResult(sequenceOfNumbers);

    }

    public static void PrintTheResult(List<int> sequenceOfNumbers)
    {
        for (int i = 0; i < sequenceOfNumbers.Count; i++)
        {
            Console.Write(sequenceOfNumbers[i] + " ");
        }
    }

    public static List<int> SumTheAbjacents(List<int> sequenceOfNumbers)
    {

        for (int i = 0; i < sequenceOfNumbers.Count - 1; i++)
        {
            if (sequenceOfNumbers[i] == sequenceOfNumbers[i + 1])
            {
                sequenceOfNumbers[i] = sequenceOfNumbers[i] + sequenceOfNumbers[i + 1];
                sequenceOfNumbers.RemoveAt(i + 1);
                i = -1; // because -1 + 1 = 0
            }
        }
        return sequenceOfNumbers;
    }
}

