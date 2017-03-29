using System;

class SmallestElementInArray
{
    static void Main()
    {
        string values = Console.ReadLine();
        string[] numbers = values.Split(' ');
        int smallestElement = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            int element = int.Parse(numbers[i]);
            if (element < smallestElement)
            {
                smallestElement = element;
            }
        }
        Console.WriteLine(smallestElement);
    }
}

