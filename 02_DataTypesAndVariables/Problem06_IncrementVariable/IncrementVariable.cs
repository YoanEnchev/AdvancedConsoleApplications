using System;

class IncrementVariable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int HowManyTimes = n / 256;
        int Value = n - (HowManyTimes * 256);
        Console.WriteLine(Value);

        if (HowManyTimes == 1)
        {
            Console.WriteLine("Overflowed " + HowManyTimes + " time");
        }
        else if (HowManyTimes > 0)
        {
            Console.WriteLine("Overflowed " + HowManyTimes + " times");
        }


    }
}

