using System;
using System.Collections.Generic;
using System.Linq;

class TearListInHalf
{
    static void Main()
    {
        string sequenceOfNumbers = Console.ReadLine();
        List<string> numbers = sequenceOfNumbers.Split(' ').ToList();

        List<int> rightSide = new List<int>();
        List<int> leftSide = new List<int>();

        leftSide = LeftSideElements(numbers, leftSide);
        rightSide = RightSideElements(numbers, rightSide);

        List<int> final = FormFinalList(leftSide, rightSide);
        PrintFinal(final);
    }

    public static void PrintFinal(List<int> final)
    {
        for (int i = 0; i < final.Count; i++)
        {
            Console.Write(final[i] + " ");
        }
    }

    public static List<int> FormFinalList(List<int> leftSide, List<int> rightSide)
    {
        List<int> final = new List<int>();

        for (int i = 0; i < leftSide.Count; i++)
        {
            final.Add(rightSide[i] / 10);
            final.Add(leftSide[i]);
            final.Add(rightSide[i] % 10);
        }
        return final;
    }

    public static List<int> RightSideElements(List<string> numbers, List<int> rightSide)
    {
        for (int i = numbers.Count / 2; i < numbers.Count; i++)
        {
            rightSide.Add(int.Parse(numbers[i]));
        }
        return rightSide;
    }

    public static List<int> LeftSideElements(List<string> numbers, List<int> leftSide)
    {
        for (int i = 0; i < (numbers.Count / 2); i++)
        {
            leftSide.Add(int.Parse(numbers[i]));
        }
        return leftSide;
    }
}

