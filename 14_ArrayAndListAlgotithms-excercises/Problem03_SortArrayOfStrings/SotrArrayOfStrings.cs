using System;
using System.Collections.Generic;
using System.Linq;

class SotrArrayOfStrings
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        string[] elements = sequence.Split(' ');
        elements = SortArray(elements);
        PrintResult(elements);
    }

    public static void PrintResult(string[] elements)
    {
        for (int i = 0; i < elements.Length; i++)
        {
            Console.Write(elements[i] + " ");
        }
    }

    public static string[] SortArray(string[] elements)
    {
        for (int i = 1; i < elements.Length; i++)
        {
            int compare = elements[i].CompareTo(elements[i - 1]);

            if (compare < 0) // swap
            {
                string left = elements[i - 1];
                string right = elements[i];

                elements[i - 1] = right;
                elements[i] = left;

                i = 0; // 0 + 1 = 1
            }
        }
        return elements;
    }
}

