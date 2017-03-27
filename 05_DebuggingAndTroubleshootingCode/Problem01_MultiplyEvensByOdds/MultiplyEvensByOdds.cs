using System;

class MultiplyEvensByOdds
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        number = Math.Abs(number);
        int digits = HowMuchDigits(number);
        Console.WriteLine(multiplyTheSumsOfOddAndEvenDigits(number, digits));
    }

    static int HowMuchDigits(int number)
    {
        int digits = 0;
        for (; number > 0; digits++)
        {
            number = number / 10;
        }
        return digits;
    }

    static int multiplyTheSumsOfOddAndEvenDigits(int number, int digits)
    {
        int sumOfEvenDigits = 0;
        int sumOfOddDigits = 0;

        int digit;

        for (int i = 10; number > 0;)
        {
            digit = number % 10;
            number = number / 10;
            if (digit % 2 == 0)
            {
                sumOfEvenDigits += digit;
            }
            else
            {
                sumOfOddDigits += digit;
            }
        }
        return sumOfEvenDigits * sumOfOddDigits;
    }
}

