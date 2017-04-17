using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers
{
    static void Main(string[] args)
    {
        List<string> numbers_asString = Console.ReadLine().Split(' ').ToList();
        List<double> numbers = ConvertFromStringToInt(numbers_asString);
        Dictionary<double, int> numberAndHowManyTimesItRepats = new Dictionary<double, int>();

        while (numbers.Count != 0)
        {
            double smallestNumber = numbers.Min();
            int occurance = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (smallestNumber == numbers[i])
                {
                    numbers.RemoveAt(i);
                    occurance++;
                    i--;
                }
            }

            numberAndHowManyTimesItRepats[smallestNumber] = occurance;
        }
        PrintNumberAndOcurrance(numberAndHowManyTimesItRepats); //in ascending order
    }

    public static void PrintNumberAndOcurrance(Dictionary<double, int> numberAndHowManyTimesItRepats)
    {
        foreach (var numberAndOcurrance in numberAndHowManyTimesItRepats)
        {
            double number = numberAndOcurrance.Key;
            int ocurrance = numberAndHowManyTimesItRepats[number];
            Console.WriteLine(number + " -> " + ocurrance); //" times"
        }
    }

    public static List<double> ConvertFromStringToInt(List<string> numbers_asString)
    {
        List<double> numbers = new List<double>();

        for (int i = 0; i < numbers_asString.Count; i++)
        {
            numbers.Add(double.Parse(numbers_asString[i]));
        }

        return numbers;
    }
}

