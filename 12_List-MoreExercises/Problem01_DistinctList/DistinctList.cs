using System;
using System.Collections.Generic;
using System.Linq;

class DistinctList
{
    public static void Main()
    {
        string sequenceOfNumbers = Console.ReadLine();
        List<string> numbers = sequenceOfNumbers.Split(' ').ToList();
        numbers = EliminateRepeatingElements(numbers);

        PrintResult(numbers);
    }

    public static void PrintResult(List<string> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }

    public static List<string> EliminateRepeatingElements(List<string> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int p = 0; p < numbers.Count; p++)
            {
                if (numbers[i] == numbers[p] && i != p)
                {
                    numbers.RemoveAt(p);
                    p--;
                }
            }
        }
        return numbers;
    }
}

