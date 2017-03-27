using System;

class OddNumbersAtOddPositions
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int element = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            element = int.Parse(numbers[i]);
            if (i % 2 != 0 && element % 2 != 0)
            {
                Console.WriteLine($"Index {i} -> {element}");
            }
        }
    }
}

