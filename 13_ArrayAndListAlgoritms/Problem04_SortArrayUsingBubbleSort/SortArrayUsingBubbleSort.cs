using System;
using System.Collections.Generic;
// LINQ is not allowed
class SortArrayUsingBubbleSort
    {
        static void Main()
        {
        string sequenceOfNumbers = Console.ReadLine();
        string[] numbers_asString = sequenceOfNumbers.Split(' ');
        int[] numbers = ConvertItFromStringToInt(numbers_asString);

        numbers = SortItByUsingBubbleSort(numbers);
        PrintSortedArrat(numbers);
        }

    public static void PrintSortedArrat(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }

    public static int[] SortItByUsingBubbleSort(int[] numbers)
    {
        bool swapped = true;

        while(swapped == true)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                swapped = false;
                if(numbers[i] > numbers[i + 1])
                {
                    int leftElement = numbers[i];
                    int rightElement = numbers[i + 1];

                    numbers[i] = rightElement;
                    numbers[i + 1] = leftElement;
                    i = -1;
                    swapped = true;
                }
            }         
        }
        return numbers;
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

