using System;

class NthDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int nthDigit = int.Parse(Console.ReadLine());

        Console.WriteLine(FindNthDigit(number, nthDigit));

    }

    static int FindNthDigit(int number, int digit)
    {
        int i = 1;
        while (i < digit)
        {
            number = number / 10;
            i++;
        }
        return number % 10;
    }
}

