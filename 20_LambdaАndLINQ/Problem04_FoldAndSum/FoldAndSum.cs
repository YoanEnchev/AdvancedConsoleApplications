using System;
using System.Collections.Generic;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
             .Split(' ')
             .Select(int.Parse)
             .ToList();

        int size = numbers.Count; //of the whole list
        int sizeOfLeftSide = size / 4;
        int sizeOfRightSide = size / 4;

        var leftSide = numbers
            .Take(sizeOfLeftSide)
            .Reverse()
            .ToList();

        var rightSide = numbers
            .Skip(sizeOfLeftSide * 3)
            .Take(sizeOfRightSide)
            .Reverse()
            .ToList();

        var upperRow = leftSide.Concat(rightSide).ToList();

        var lowerRow = numbers
             .Skip(sizeOfLeftSide)
             .Take(2 * sizeOfRightSide)
             .ToList();

        GetAndPrintSum(upperRow, lowerRow);
    }

    public static void GetAndPrintSum(List<int> upperRow, List<int> lowerRow)
    {
        for (int i = 0; i < upperRow.Count; i++)
        {
            Console.Write(upperRow[i] + lowerRow[i] + " ");
        }
    }
}

