using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveNegativeNumbersAndRev
{
    public static void Main()
    {
        string sequence = Console.ReadLine();

        List<string> numbers = new List<string>();
        numbers = sequence.Split(' ').ToList();

        List<int> values = new List<int>();

        for (int i = 0; i <= numbers.Count - 1; i++)
        {
            values.Add(int.Parse(numbers[i]));
        }

        RemoveNegativesNumbersAndReverse(values); // also print result
    }

    public static void RemoveNegativesNumbersAndReverse(List<int> values)
    {
        for (int i = 0; i < values.Count; i++)
        {
            if (values[i] < 0)
            {
                values.RemoveAt(i);
            }
        }

        values.Reverse();
        string result = "";
        for (int i = 0; i < values.Count; i++)
        {
            if (values[i] >= 0)
            {
                result += values[i] + " ";
            }
        }

        if (result != "")
        {
            Console.WriteLine(result);
        }

        else
        {
            Console.WriteLine("empty");
        }
    }
}

