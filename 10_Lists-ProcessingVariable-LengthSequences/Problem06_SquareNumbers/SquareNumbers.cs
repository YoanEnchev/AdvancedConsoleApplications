using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        List<string> numbersAsString = sequence.Split(' ').ToList();
        List<int> numbers = new List<int>();

        for (int i = 0; i < numbersAsString.Count; i++)
        {
            numbers.Add(int.Parse(numbersAsString[i]));
        }

        GetSquareNumber(numbers); // also print result
    }

    public static void GetSquareNumber(List<int> numbers)
    {
        List<int> squareNumber = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
            {
                squareNumber.Add(numbers[i]);
            }
        }
        squareNumber.Sort();
        squareNumber.Reverse();

        for (int i = 0; i < squareNumber.Count; i++)
        {
            Console.Write(squareNumber[i] + " ");
        }
    }
}

