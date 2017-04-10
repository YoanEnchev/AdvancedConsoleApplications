using System;
using System.Collections.Generic;
using System.Linq;

class UnunionLists
{
    static void Main()
    {
        string sequenceOfNumbers = Console.ReadLine();
        List<string> primalList = sequenceOfNumbers.Split(' ').ToList();

        int howManyOtherLists = int.Parse(Console.ReadLine());

        for (int i = 0; i < howManyOtherLists; i++)
        {
            string sequence = Console.ReadLine();
            List<string> nonPrimalList = sequence.Split(' ').ToList();

            primalList = RemoveRepeatingElementsAndConcatenate(primalList, nonPrimalList);
        }
        ConvertToIntAndPrintResult(primalList);
    }

    public static void ConvertToIntAndPrintResult(List<string> primalList)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < primalList.Count; i++)
        {
            if (primalList[i] != null)
            {
                result.Add(int.Parse(primalList[i]));
            }
        }

        result.Sort();

        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i] + " ");
        }
    }

    public static List<string> RemoveRepeatingElementsAndConcatenate(List<string> primalList, List<string> nonPrimalList)
    {
        List<int> deleteAtPosition_primalList = new List<int>();
        List<int> deleteAtPosition_nonPrimalList = new List<int>();

        for (int i = 0; i < primalList.Count; i++) // get positions of repeating elements
        {
            for (int p = 0; p < nonPrimalList.Count; p++)
            {
                if (primalList[i] == nonPrimalList[p])
                {
                    deleteAtPosition_primalList.Add(i);
                    deleteAtPosition_nonPrimalList.Add(p);
                }
            }
        }

        if (deleteAtPosition_primalList.Count != 0)
        {
            for (int i = 0; i < deleteAtPosition_primalList.Count; i++) // delete repeating elements
            {
                primalList[deleteAtPosition_primalList[i]] = null;
            }

            for (int i = 0; i < deleteAtPosition_nonPrimalList.Count; i++) // delete repeating elements
            {
                nonPrimalList[deleteAtPosition_nonPrimalList[i]] = null;
            }
        }
        List<string> PrimalAndNonPrimal = new List<string>();

        for (int i = 0; i < primalList.Count; i++)
        {
            PrimalAndNonPrimal.Add(primalList[i]);
        }

        for (int i = 0; i < nonPrimalList.Count; i++)
        {
            PrimalAndNonPrimal.Add(nonPrimalList[i]);
        }
        return PrimalAndNonPrimal;
    }
}


