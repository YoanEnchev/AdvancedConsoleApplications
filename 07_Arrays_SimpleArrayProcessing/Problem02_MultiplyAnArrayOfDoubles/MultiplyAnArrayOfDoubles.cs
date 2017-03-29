using System;

class MultiplyAnArrayOfDoubles
{
    static void Main()
    {
        string values = Console.ReadLine();
        double p = double.Parse(Console.ReadLine());

        string[] numbers = values.Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            double element = double.Parse(numbers[i]);
            Console.Write(element * p + " ");
        }

    }
}

