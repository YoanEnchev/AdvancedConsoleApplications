using System;
using System.Collections.Generic;
// LINQ is not allowed
class ArrayContainsElement
{
    static void Main()
    {
        string sequenceOfNumber = Console.ReadLine();
        string[] numbers = sequenceOfNumber.Split(' ');

        string containedNumber = Console.ReadLine();
        bool isNumberContained = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == containedNumber)
            {
                isNumberContained = true;
            }
        }

        if (isNumberContained == true)
        {
            Console.WriteLine("yes");
        }

        else
        {
            Console.WriteLine("no");
        }
    }
}

