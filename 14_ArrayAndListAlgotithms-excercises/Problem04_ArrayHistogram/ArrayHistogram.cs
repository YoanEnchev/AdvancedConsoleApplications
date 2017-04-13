using System;
using System.Collections.Generic;
using System.Linq;

class ArrayHistogram
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        string[] elements = sequence.Split(' ');
        List<string> result = new List<string>();

        for (int i = 0; i < elements.Length; i++)
        {
            double howManyTimes = FindHowManyTimesElementRepeats(elements, i);
            double percent = howManyTimes / (elements.Length) * 100;

            result.Add($"{elements[i]} -> {howManyTimes} times ({percent:F2}%)");
        }

        PrintResultInDecendingOrder(result);
    }

    public static void PrintResultInDecendingOrder(List<string> result)
    {
        while (result.Count != 0)
        {
            Console.WriteLine(PrintMostRepeatingElementAndThenDeleteIt(result));
        }
    }

    public static string PrintMostRepeatingElementAndThenDeleteIt(List<string> result)
    {
        int howMuchElementRepeats_previously = 0;
        int howMuchElementRepeats_now = 0;
        int whichIndex = -1;
        string printPartOfResult;

        for (int i = 0; i < result.Count; i++)
        {
            for (int p = 0; p < result.Count; p++)
            {
                if (result[i] == result[p])
                {
                    howMuchElementRepeats_now++;
                    if (howMuchElementRepeats_now > howMuchElementRepeats_previously)
                    {
                        whichIndex = i;
                    }
                }
            }

            if (howMuchElementRepeats_previously < howMuchElementRepeats_now)
            {
                howMuchElementRepeats_previously = howMuchElementRepeats_now;
            }
            howMuchElementRepeats_now = 0;
        }
        printPartOfResult = result[whichIndex];

        for (int i = 0; i < result.Count; i++)
        {
            if (printPartOfResult == result[i])
            {
                result.RemoveAt(i);
                i = -1;
            }
        }
        return printPartOfResult;
    }
    public static int FindHowManyTimesElementRepeats(string[] elements, int i)
    {
        int howManyTimes = 0;

        for (int p = 0; p < elements.Length; p++)
        {
            if (elements[i] == elements[p] && elements[i] != null)
            {
                howManyTimes++;
            }
        }

        return howManyTimes;
    }
}

