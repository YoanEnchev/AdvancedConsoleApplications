using System;
using System.Collections.Generic;
using System.Linq;

class IncreasingCrisis
{
    static void Main()
    {
        int howManySequences = int.Parse(Console.ReadLine());
        List<int> result = new List<int>();

        for (int i = 0; i < howManySequences; i++)
        {
            List<string> sequence_AsString = Console.ReadLine().Split(' ').ToList();
            List<int> sequence = ConvertFromStringToInt(sequence_AsString);

            if (i == 0)
            {
                result = sequence;
            }

            else
            {
                result = addNewSequenceAtProperPlace(result, sequence);
            }
        }

        PrintResult(result);
    }

    public static void PrintResult(List<int> result)
    {
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i] + " ");
        }
    }

    public static List<int> addNewSequenceAtProperPlace(List<int> result, List<int> sequence)
    {
        int index = result.Count;
        bool indexFound = false;

        for (int i = 0; i < result.Count && indexFound == false; i++)
        {
            if (sequence[0] < result[i])
            {
                index = i;
                indexFound = true;
            }
        }

        for (int i = 0; i < sequence.Count; i++)
        {
            result.Insert(index, sequence[i]);
            index++;
        }

        return result;
    }

    public static List<int> ReformatBrokenSequence(List<int> result)
    {
        for (int i = 0; i < result.Count - 1; i++)
        {
            if (result[i] > result[i + 1])
            {
                while (i < result.Count - 1)
                {
                    result.RemoveAt(i + 1);
                }
            }
        }

        return result;
    }

    public static List<int> ConvertFromStringToInt(List<string> sequence_AsString)
    {
        List<int> sequence = new List<int>();

        for (int i = 0; i < sequence_AsString.Count; i++)
        {
            sequence.Add(int.Parse(sequence_AsString[i]));
        }

        return sequence;
    }
}

