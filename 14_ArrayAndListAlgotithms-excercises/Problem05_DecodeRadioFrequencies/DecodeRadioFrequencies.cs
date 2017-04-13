using System;
using System.Collections.Generic;
using System.Linq;

class DecodeRadioFrequencies
{
    static void Main()
    {
        string sequenceOfNumbers = Console.ReadLine();
        List<string> numbers_asString = sequenceOfNumbers.Split(' ').ToList();
        List<double> numbers = ConvertFromStringToDouble(numbers_asString);
        List<char> result = ConvertToASCII(numbers, numbers_asString);
        PrintResultInProperWay(result);
    }

    public static void PrintResultInProperWay(List<char> result)
    {
        for (int i = 0; i < result.Count; i += 2)
        {
            if (result[i] > 31 && result[i] < 132)
            {
                Console.Write(result[i]);
            }
        }

        for (int i = result.Count - 1; i > 0; i -= 2)
        {
            if (result[i] > 31 && result[i] < 132)
            {
                Console.Write(result[i]);
            }
        }
    }

    public static List<char> ConvertToASCII(List<double> numbers, List<string> numbers_asString)
    {
        List<char> result = new List<char>(25);

        for (int i = 0; i < numbers.Count; i++)
        {
            int partBeforePoint = (int)numbers[i];
            string beforePoint = numbers[i] + "";

            string afterPoint = "";
            int whichSymbol = 0;

            if (partBeforePoint < 100)
            {
                whichSymbol = 3;
            }

            if (partBeforePoint >= 100)
            {
                whichSymbol = 4;
            }

            while (whichSymbol < beforePoint.Length) //because of ""
            {
                afterPoint += beforePoint[whichSymbol];
                whichSymbol++;
            }

            string theNumbersAsString = numbers_asString[i];

            int p = 1;

            if (theNumbersAsString[theNumbersAsString.Length - 1] == '0')
            {
                while (theNumbersAsString[theNumbersAsString.Length - p] == '0')
                {
                    afterPoint += "0";
                    p++;
                }
            }

            int partAfterPoint = int.Parse(afterPoint);

            result.Add((char)partBeforePoint);
            result.Add((char)partAfterPoint);
        }
        return result;
    }

    public static List<double> ConvertFromStringToDouble(List<string> numbers_asString)
    {
        List<double> numbers = new List<double>();

        for (int i = 0; i < numbers_asString.Count; i++)
        {
            numbers.Add(double.Parse(numbers_asString[i]));
        }

        return numbers;
    }
}

