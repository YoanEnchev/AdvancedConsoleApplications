using System;
using System.Collections.Generic;
using System.Linq;
class SortNumbers
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        List<string> numbersAsString = sequence.Split(' ').ToList();

        List<decimal> numbers = new List<decimal>();

        for (int i = 0; i < numbersAsString.Count; i++)
        {
            numbers.Add(decimal.Parse(numbersAsString[i]));
        }

        numbers.Sort();
        PrintResult(numbers);
    }

    public static void PrintResult(List<decimal> numbers)
    {
        string result = "";
        for (int i = 0; i < numbers.Count; i++)
        {
            if (i != numbers.Count - 1)
            {
                result += numbers[i] + " " + "<=" + " ";
            }

            else
            {
                result += numbers[i];
            }
        }
        Console.WriteLine(result);
    }
}

