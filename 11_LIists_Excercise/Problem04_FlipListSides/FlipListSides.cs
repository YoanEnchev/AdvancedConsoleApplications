using System;
using System.Collections.Generic;
using System.Linq;

public class FlipListSides
{
    public static void Main()
    {
        string sequenceOfNumbers = Console.ReadLine();
        List<string> numbersInList = sequenceOfNumbers.Split(' ').ToList();
        List<int> numbers = new List<int>();

        for (int i = 0; i < numbersInList.Count; i++)
        {
            numbers.Add(int.Parse(numbersInList[i]));
        }

        ExchangeElementsAndPrintResult(numbers);
    }


    public static void ExchangeElementsAndPrintResult(List<int> numbers)
    {
        int firstElement = numbers[0];
        int lastElement = numbers[numbers.Count - 1];

        numbers.Reverse();

        numbers.RemoveAt(0);
        numbers.RemoveAt(numbers.Count - 1);

        string middleElements = "";

        for (int i = 0; i < numbers.Count; i++)
        {
            middleElements += numbers[i] + " ";
        }

        Console.WriteLine(firstElement +" " + middleElements + lastElement);
    }
}

