using System;
using System.Collections.Generic;
//Linq is not allowrd
class LargestNElements
{
    static void Main()
    {
        string sequenceOfNumbers = Console.ReadLine();
        int howManyElements = int.Parse(Console.ReadLine());

        string[] numbers_asStrings = sequenceOfNumbers.Split(' ');
        List<int> numbers = ConvertFromStringToInt(numbers_asStrings);

        List<int> largerstElements = GetLargerstElements(numbers, howManyElements);
        PrintLargestElements(largerstElements);
    }

    public static void PrintLargestElements(List<int> largerstElements)
    {
        for (int i = 0; i < largerstElements.Count; i++)
        {
            Console.Write(largerstElements[i] + " ");
        }
    }

    public static List<int> GetLargerstElements(List<int> numbers, int howManyElements)
    {
        List<int> largerstElements = new List<int>();
        numbers.Sort();
        numbers.Reverse();

        for (int i = 0; i < howManyElements; i++)
        {
            largerstElements.Add(numbers[i]);
        }

        return largerstElements;
    }

    public static List<int> ConvertFromStringToInt(string[] numbers_asStrings)
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < numbers_asStrings.Length; i++)
        {
            numbers.Add(int.Parse(numbers_asStrings[i]));
        }

        return numbers;
    }
}

