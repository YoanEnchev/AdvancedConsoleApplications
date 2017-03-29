using System;

class CountOfNegativeNumbersInArray
{
    static void Main()
    {
        int[] numbers = new int[int.Parse(Console.ReadLine())];
        int counter = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            if (numbers[i] < 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

