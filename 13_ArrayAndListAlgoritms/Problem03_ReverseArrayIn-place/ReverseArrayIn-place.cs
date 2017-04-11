using System;
using System.Collections.Generic;
// LINQ is not allowed

class ReverseArrayInplace
{
    static void Main()
    {
        string sequenceOfNumbers = Console.ReadLine();
        string[] elements = sequenceOfNumbers.Split(' ');

        elements = ReverseArray(elements);
        PrintReversedArray(elements);
    }

    public static void PrintReversedArray(string[] elements)
    {
        for (int i = 0; i < elements.Length; i++)
        {
            Console.Write(elements[i] + " ");
        }
    }

    public static string[] ReverseArray(string[] elements)
    {
        string[] reversed = new string[elements.Length];

        for (int i = 0; i < elements.Length; i++)
        {
            reversed[i] = elements[elements.Length - 1 - i];
        }

        return reversed;
    }
}

