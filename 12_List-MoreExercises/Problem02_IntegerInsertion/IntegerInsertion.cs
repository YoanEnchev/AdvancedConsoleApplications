using System;
using System.Collections.Generic;
using System.Linq;

class IntegerInsertion
{
    static void Main()
    {
        string sequenceOfNumbers_1 = Console.ReadLine();
        string sequenceOfNumbers_2 = "";

        List<string> numbers_1_AsString = sequenceOfNumbers_1.Split(' ').ToList();
        List<string> numbers_2_AsString = new List<string>();
        
        while (sequenceOfNumbers_2 != "end")
        {
            sequenceOfNumbers_2 = Console.ReadLine();
            numbers_2_AsString.Add(sequenceOfNumbers_2);
        }

        numbers_2_AsString.RemoveAt(numbers_2_AsString.Count - 1);//remove end

        List<int> numbers_1 = new List<int>();
        List<int> numbers_2 = new List<int>();

        numbers_1 = ConvertItToInt_1(numbers_1_AsString);
        numbers_2 = ConvertItToInt_2(numbers_2_AsString);

       List <int> result = FormFinalList(numbers_1, numbers_2);
        PrintResult(result);
    }

    public static void PrintResult(List<int> result)
    {
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i] + " ");
        }
    }

    public static List<int> FormFinalList(List<int> numbers_1, List<int> numbers_2)
    {
        for (int i = 0; i < numbers_2.Count; i++)
        {
            string numberAsString = numbers_2[i] + "";
            char firstDigitAsChar = numberAsString[0];
            int firstDigit = firstDigitAsChar - 48; // ASCII

            numbers_1.Insert(firstDigit, numbers_2[i]);           
       }
        return numbers_1;
    }

    public static List<int> ConvertItToInt_2(List<string> numbers_2_AsString)
    {
        List<int> numbers_2 = new List<int>();
        for (int i = 0; i < numbers_2_AsString.Count; i++)
        {
            numbers_2.Add(int.Parse(numbers_2_AsString[i]));
        }
        return numbers_2;
    }

    public static List<int> ConvertItToInt_1(List<string> numbers_1_AsString)
    {
        List<int> numbers_1 = new List<int>();
        for (int i = 0; i < numbers_1_AsString.Count; i++)
        {
            numbers_1.Add(int.Parse(numbers_1_AsString[i]));
        }
        return numbers_1;
    }
}

