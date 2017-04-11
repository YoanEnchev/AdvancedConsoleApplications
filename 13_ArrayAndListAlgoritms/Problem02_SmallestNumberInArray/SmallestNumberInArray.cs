using System;
using System.Collections.Generic;
// LINQ is not allowed
class SmallestNumberInArray
    {
        static void Main()
        {
        string sequenceOfNumber = Console.ReadLine();
        string[] numbers_asString = sequenceOfNumber.Split(' ');

 
        int[] numbers = ConvertItFromStringToInt(numbers_asString);

        FindSmallestNumberAndPrintIt(numbers);

        }

    public static void FindSmallestNumberAndPrintIt(int[] numbers)
    {
        int smallestNumber = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if(smallestNumber > numbers[i])
            {
                smallestNumber = numbers[i];
            }
        }

        Console.WriteLine(smallestNumber);
    }

    public static int[] ConvertItFromStringToInt(string[] numbers_asString)
    {
        int[] numbers = new int[numbers_asString.Length];

        for (int i = 0; i < numbers_asString.Length; i++)
        {
            numbers[i] = int.Parse(numbers_asString[i]);
        }

        return numbers;
    }
}

