using System;

class SignOfIntegerNumber
{
    static void Main()
    {

        PrintSigns(int.Parse(Console.ReadLine()));
    }

    static void PrintSigns(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("The number {0} is positive.", number);
        }

        if (number < 0)
        {
            Console.WriteLine("The number {0} is negative.", number);
        }

        if (number == 0)
        {
            Console.WriteLine("The number {0} is zero.", number);
        }
    }
}

