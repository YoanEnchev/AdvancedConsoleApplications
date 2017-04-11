using System;
using System.Collections.Generic;
// LINQ is not allowed
class SortArrayUsingInsertionSort
{
    static void Main()
    {
        string sequenceOfNumbers = Console.ReadLine();
        string[] numbers_asString = sequenceOfNumbers.Split(' ');
        int[] numbers = ConvertFromStringToInt(numbers_asString);

        numbers = SortArrayByUsingInsertionSort(numbers); // 5 4 3 2 0...
        PrintSortedArray(numbers);
    }

    public static void PrintSortedArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }

    public static int[] SortArrayByUsingInsertionSort(int[] numbers)
    {
        for (int i = 1; i < numbers.Length; i++)
        {
            bool swap = false;
            int position = i;

            while (position >= 1 && numbers[i] < numbers[position - 1])
            {
                position--;
                swap = true;
            }

            int number_1 = numbers[i];
            int number_2 = numbers[position];

            numbers[i] = number_2;
            numbers[position] = number_1;

            if (swap == true)
            {
                i = 0;
            }
        }
        return numbers;
    }

    public static int[] ConvertFromStringToInt(string[] numbers_asString)
    {
        int[] numbers = new int[numbers_asString.Length];

        for (int i = 0; i < numbers_asString.Length; i++)
        {
            numbers[i] = int.Parse(numbers_asString[i]);
        }

        return numbers;
    }
}

