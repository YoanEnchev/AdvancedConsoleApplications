using System;
using System.Collections.Generic;
using System.Linq;

public class OddOcurrences
{
    static void Main()
    {
        List<string> sequence = Console.ReadLine().Split(' ').ToList();
        sequence = LowercaseAllElements(sequence);
        Dictionary<string, int> wordAndOcurrance = new Dictionary<string, int>();

        for (int i = 0; i < sequence.Count; i++)
        {
            string currentElement = sequence[i];
            int occurance = HowManyTimesElementRepeats(currentElement, sequence);
            sequence = deleteDublicatesOfCurrentElement(sequence, currentElement);
            wordAndOcurrance[currentElement] = occurance;
            i--;
        }

        PrintOddOccurances(wordAndOcurrance);
    }

    public static void PrintOddOccurances(Dictionary<string, int> wordAndOcurrance)
    {
        string result = "";

        foreach (var wordsAndOccurances in wordAndOcurrance)
        {
            int occurance = wordsAndOccurances.Value;

            if (occurance % 2 != 0)
            {
                result += wordsAndOccurances.Key + ", ";
            }
        }
        result = result.Remove(result.Length - 2);

        Console.WriteLine(result);
    }

    public static List<string> deleteDublicatesOfCurrentElement(List<string> sequence, string currentElement)
    {
        for (int i = 0; i < sequence.Count; i++)
        {
            if (currentElement == sequence[i])
            {
                sequence.RemoveAt(i);
                i--;
            }
        }

        return sequence;
    }

    public static int HowManyTimesElementRepeats(string currentElement, List<string> sequence)
    {
        int occurance = 0;

        for (int i = 0; i < sequence.Count; i++)
        {
            if (currentElement == sequence[i])
            {
                occurance++;
            }
        }

        return occurance;
    }

    public static List<string> LowercaseAllElements(List<string> sequence)
    {
        for (int i = 0; i < sequence.Count; i++)
        {
            sequence[i] = sequence[i].ToLower();
        }

        return sequence;
    }
}

