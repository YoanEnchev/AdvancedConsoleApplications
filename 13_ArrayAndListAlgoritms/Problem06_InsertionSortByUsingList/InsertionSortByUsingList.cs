using System;
using System.Collections.Generic;
//LINQ is not allowed
class InsertionSortByUsingList
{
    static void Main()
    {
        string sequenceOfNumbers = Console.ReadLine();
        string[] numbers_asString = sequenceOfNumbers.Split(' ');
        List<int> numbers = ConvertItFromIntToString(numbers_asString);

        numbers = SortListUsingInsertion(numbers);
        PrintResult(numbers);
    }

    public static void PrintResult(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }

    public static List<int> SortListUsingInsertion(List<int> numbers)
    {

        for (int i = 1; i < numbers.Count; i++)
        {
            bool shifted = false;
            int position = i;

            while (position >= 1 && numbers[position] < numbers[position - 1])
            {
                position--;
                shifted = true;
            }

            if (shifted == true)
            {
                int number_1 = numbers[position];
                int number_2 = numbers[i];

                numbers[position] = number_2;
                numbers[i] = number_1;

                i = 0;
            }
        }
        return numbers;
    }

    public static List<int> ConvertItFromIntToString(string[] numbers_asString)
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < numbers_asString.Length; i++)
        {
            numbers.Add(int.Parse(numbers_asString[i]));
        }

        return numbers;
    }
}

