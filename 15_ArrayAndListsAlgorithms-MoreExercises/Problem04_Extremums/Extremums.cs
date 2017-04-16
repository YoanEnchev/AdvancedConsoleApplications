using System;
using System.Collections.Generic;
using System.Linq;

class Extremums
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        List<string> numbers = sequence.Split(' ').ToList();
        List<int> result = new List<int>();

        string MinOrMax = Console.ReadLine();

        if (MinOrMax == "Min")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int smallestNumber = RotateItToSmallestNumber(numbers[i]);
                result.Add(smallestNumber);
            }
        }

        if (MinOrMax == "Max")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int biggestNumber = RotateItToBiggestNumber(numbers[i]);
                result.Add(biggestNumber);
            }
        }

        PrintResult(result);
        Console.WriteLine();
        Console.Write(result.Sum());
    }

    public static int RotateItToBiggestNumber(string number)
    {
        int biggestNumber = int.Parse(number);
        string rotatedNumber = "";
        int totalRotations = number.Length;
        int rotation = 0;

        for (int i = 0; i < number.Length; i++)
        {
            while (rotation < totalRotations)
            {
                for (int p = 1; p < number.Length; p++)
                {
                    rotatedNumber += number[p];
                }
                rotatedNumber += number[0];

                if (biggestNumber < int.Parse(rotatedNumber))
                {
                    biggestNumber = int.Parse(rotatedNumber);
                }
                number = rotatedNumber;
                rotatedNumber = "";
                rotation++;
            }
        }
        return biggestNumber;
    }


    public static void PrintResult(List<int> result)
    {
        for (int i = 0; i < result.Count; i++)
        {
            if (i != result.Count - 1)
            {
                Console.Write(result[i] + ", ");
            }

            if (i == result.Count - 1)
            {
                Console.Write(result[i]);
            }
        }
    }

    public static int RotateItToSmallestNumber(string number)
    {
        int smallestNumber = int.Parse(number);
        string rotatedNumber = "";
        int totalRotations = number.Length;
        int rotation = 0;

        for (int i = 0; i < number.Length; i++)
        {
            while (rotation < totalRotations)
            {
                for (int p = 1; p < number.Length; p++)
                {
                    rotatedNumber += number[p];
                }
                rotatedNumber += number[0];

                if (smallestNumber > int.Parse(rotatedNumber))
                {
                    smallestNumber = int.Parse(rotatedNumber);
                }
                number = rotatedNumber;
                rotatedNumber = "";
                rotation++;
            }
        }
        return smallestNumber;
    }
}

