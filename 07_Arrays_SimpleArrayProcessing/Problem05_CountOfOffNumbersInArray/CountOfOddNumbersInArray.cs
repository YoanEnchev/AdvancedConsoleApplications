using System;

class CountOfOddNumbersInArray
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] values = input.Split(' ');

        int counter = 0;

        for (int i = 0; i < values.Length; i++)
        {
            int element = int.Parse(values[i]);

            if (element % 2 != 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

