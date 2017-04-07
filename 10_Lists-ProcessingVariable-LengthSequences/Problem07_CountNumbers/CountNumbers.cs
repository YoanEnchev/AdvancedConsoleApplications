using System;
using System.Collections.Generic;
using System.Linq;

class CountNumbers
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        List<string> numbersAsString = sequence.Split(' ').ToList();
        List<int> numbers = new List<int>();

        for (int i = 0; i < numbersAsString.Count; i++)
        {
            numbers.Add(int.Parse(numbersAsString[i]));
        }

        numbers.Sort();

        HowManyTimesANumbersIsRepeating(numbers); // also print result
    }

    public static void HowManyTimesANumbersIsRepeating(List<int> numbers)
    {
        int numberRepeated = 0;
        int whichNumber = 0;
        string result = "";

        for (int i = 0; i < 1000; i++)
        {
            for (int p = 0; p < numbers.Count; p++)
            {
                if (numbers[p] == i)
                {
                    whichNumber = i;
                    numberRepeated++;
                }
            }
            if (numberRepeated != 0)
            {
                result += whichNumber + " -> " + numberRepeated;
                result += Environment.NewLine;
            }
            numberRepeated = 0;
        }
        Console.WriteLine(result);
    }
}

