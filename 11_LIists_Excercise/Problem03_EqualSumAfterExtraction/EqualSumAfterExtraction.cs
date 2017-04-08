using System;
using System.Collections.Generic;
using System.Linq;

class EqualSumAfterExtraction
{
    static void Main()
    {
        string sequenceOfNumbers_1 = Console.ReadLine();
        string sequenceOfNumbers_2 = Console.ReadLine();

        List<string> numbersInList_1 = sequenceOfNumbers_1.Split(' ').ToList();
        List<string> numbersInList_2 = sequenceOfNumbers_2.Split(' ').ToList();

        List<int> numbers_1 = new List<int>();
        List<int> numbers_2 = new List<int>();

        for (int i = 0; i < numbersInList_1.Count; i++)
        {
            numbers_1.Add(int.Parse(numbersInList_1[i]));
        }

        for (int i = 0; i < numbersInList_2.Count; i++)
        {
            numbers_2.Add(int.Parse(numbersInList_2[i]));
        }

        numbers_2 = RemoveElementsFromNumber_2(numbers_1, numbers_2);

        SumAndPrintResult(numbers_1, numbers_2);
    }

    public static void SumAndPrintResult(List<int> numbers_1, List<int> numbers_2)
    {
        int sum_1 = 0;
        int sum_2 = 0;

        for (int i = 0; i < numbers_1.Count; i++)
        {
            sum_1 += numbers_1[i];
        }

        for (int i = 0; i < numbers_2.Count; i++)
        {
            sum_2 += numbers_2[i];
        }

        if (sum_1 == sum_2)
        {
            Console.WriteLine($"Yes. Sum: {sum_1}");
        }

        else
        {
            int diffrence = Math.Abs(sum_1 - sum_2);
            Console.WriteLine($"No. Diff: {diffrence}");
        }
    }

    public static List<int> RemoveElementsFromNumber_2(List<int> numbers_1, List<int> numbers_2)
    {
        for (int i = 0; i < numbers_1.Count; i++)
        {
            for (int p = 0; p < numbers_2.Count; p++)
            {
                if (numbers_1[i] == numbers_2[p])
                {
                    numbers_2.RemoveAt(p);
                    p--;
                }
            }
        }
        return numbers_2;
    }
}

