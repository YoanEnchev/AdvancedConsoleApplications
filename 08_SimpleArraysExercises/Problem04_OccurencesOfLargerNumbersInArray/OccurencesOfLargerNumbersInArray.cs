using System;

class OccurencesOfLargerNumbersInArray
{
    static void Main()
    {
        string values = Console.ReadLine();
        string[] numbers = values.Split(' ');

        double numberToCompare = double.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            double elementOfArray = double.Parse(numbers[i]);
            if (numberToCompare < elementOfArray)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

