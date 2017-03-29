using System;

class IncreasingSequenceOfElements
{
    static void Main()
    {
        string values = Console.ReadLine();
        string[] numbers = values.Split(' ');

        int previousElement = int.MinValue;
        string isItIncreasing = "Yes";

        for (int i = 0; i < numbers.Length; i++)
        {
            int elementOfArray = int.Parse(numbers[i]);
            if (elementOfArray < previousElement)
            {
                isItIncreasing = "No";
            }
            previousElement = elementOfArray;
        }
        Console.WriteLine(isItIncreasing);
    }
}

