using System;

class Program
{
    static void Main()
    {

        int howMany = int.Parse(Console.ReadLine());
        int[] numbers = new int[howMany];
        int largestElement = int.MinValue;

        for (int i = 0; i < howMany; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());

            if (largestElement <= numbers[i])
            {
                largestElement = numbers[i];
            }
        }
        Console.WriteLine(largestElement);
    }
}

