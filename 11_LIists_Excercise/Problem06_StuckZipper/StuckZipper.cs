using System;
using System.Collections.Generic;
using System.Linq;

class StuckZipper
{
    static void Main()
    {
        string sequenceOfNumbers_1 = Console.ReadLine();
        string sequenceOfNumbers_2 = Console.ReadLine();

        List<string> elements_1 = sequenceOfNumbers_1.Split(' ').ToList();
        List<string> elements_2 = sequenceOfNumbers_2.Split(' ').ToList();

        List<int> numbers_1 = new List<int>();
        List<int> numbers_2 = new List<int>();

        numbers_1 = ConvertToInteger_1(elements_1);
        numbers_2 = ConvertToInteger_2(elements_2);

        int digits_1 = HowManyDigitsSmallestDigitNumberHas_1(numbers_1);
        int digits_2 = HowManyDigitsSmallestDigitNumberHas_2(numbers_2);

        int leastDigitsInNumber = 0;

        if (digits_1 < digits_2)
        {
            leastDigitsInNumber = digits_1;
        }

        else
        {
            leastDigitsInNumber = digits_2;
        }

        numbers_1 = EliminateElements_1(numbers_1, leastDigitsInNumber, elements_1); //that have more digits
        numbers_2 = EliminateElements_2(numbers_2, leastDigitsInNumber, elements_2); //than smalest number

        PrintResult(numbers_1, numbers_2);
    }

    public static void PrintResult(List<int> numbers_1, List<int> numbers_2)
    {
        int listWithLongerCount = 0;

        if (numbers_1.Count > numbers_2.Count)
        {
            listWithLongerCount = numbers_1.Count;
        }

        else
        {
            listWithLongerCount = numbers_2.Count;
        }

        for (int i = 0; i < listWithLongerCount; i++)
        {
            if (i < numbers_2.Count)
            {
                Console.Write(numbers_2[i] + " ");
            }

            if (i < numbers_1.Count)
            {
                Console.Write(numbers_1[i] + " ");
            }
        }
    }

    public static List<int> EliminateElements_2(List<int> numbers_2, int leastDigitsInNumber, List<string> elements_2)
    {
        for (int i = 0; i < numbers_2.Count; i++)
        {
            int digitsOfCurrentNumber = 0;
            int currentNumber = Math.Abs(numbers_2[i]);

            if (currentNumber != 0)
            {
                while (currentNumber > 0)
                {
                    currentNumber = currentNumber / 10;
                    digitsOfCurrentNumber++;
                }
            }

            else
            {
                digitsOfCurrentNumber = 1;
            }

            if (digitsOfCurrentNumber > leastDigitsInNumber)
            {
                numbers_2.RemoveAt(i);
                elements_2.RemoveAt(i);
                i--;
            }
        }
        return numbers_2;
    }

    public static List<int> EliminateElements_1(List<int> numbers_1, int leastDigitsInNumber, List<string> elements_1)
    {
        for (int i = 0; i < numbers_1.Count; i++)
        {
            int digitsOfCurrentNumber = 0;
            int currentNumber = Math.Abs(numbers_1[i]);

            if (currentNumber != 0)
            {
                while (currentNumber > 0)
                {
                    currentNumber = currentNumber / 10;
                    digitsOfCurrentNumber++;
                }
            }

            else
            {
                digitsOfCurrentNumber = 1;
            }

            if (digitsOfCurrentNumber > leastDigitsInNumber)
            {
                numbers_1.RemoveAt(i);
                elements_1.RemoveAt(i);
                i--;
            }
        }
        return numbers_1;
    }

    public static int HowManyDigitsSmallestDigitNumberHas_2(List<int> numbers_2)
    {
        int leastDigitNumber = 100;
        int digitsOfCurrentNumber = 0;

        for (int i = 0; i < numbers_2.Count; i++)
        {
            int currentNumber = Math.Abs(numbers_2[i]);

            if (currentNumber != 0)
            {
                while (currentNumber > 0)
                {
                    currentNumber = currentNumber / 10;
                    digitsOfCurrentNumber++;
                }
            }

            else
            {
                digitsOfCurrentNumber = 1;
            }

            if (digitsOfCurrentNumber < leastDigitNumber)
            {
                leastDigitNumber = digitsOfCurrentNumber;
            }
            digitsOfCurrentNumber = 0;
        }
        return leastDigitNumber;
    }

    public static int HowManyDigitsSmallestDigitNumberHas_1(List<int> numbers_1)
    {
        int leastDigitNumber = 100;
        int digitsOfCurrentNumber = 0;

        for (int i = 0; i < numbers_1.Count; i++)
        {
            int currentNumber = Math.Abs(numbers_1[i]);

            if (currentNumber != 0)
            {
                while (currentNumber > 0)
                {
                    currentNumber = currentNumber / 10;
                    digitsOfCurrentNumber++;
                }
            }

            else
            {
                digitsOfCurrentNumber = 1;
            }

            if (digitsOfCurrentNumber < leastDigitNumber)
            {
                leastDigitNumber = digitsOfCurrentNumber;
            }
            digitsOfCurrentNumber = 0;
        }
        return leastDigitNumber;
    }

    public static List<int> ConvertToInteger_2(List<string> elements_2)
    {
        List<int> numbers_2 = new List<int>();

        for (int i = 0; i < elements_2.Count; i++)
        {
            numbers_2.Add(int.Parse(elements_2[i]));
        }
        return numbers_2;
    }

    public static List<int> ConvertToInteger_1(List<string> elements_1)
    {
        List<int> numbers_1 = new List<int>();

        for (int i = 0; i < elements_1.Count; i++)
        {
            numbers_1.Add(int.Parse(elements_1[i]));
        }
        return numbers_1;
    }
}

