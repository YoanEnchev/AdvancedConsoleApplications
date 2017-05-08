using System;
using System.Numerics;

class BigFactorial
{
    static void Main()
    {
        int factorial = int.Parse(Console.ReadLine());
        BigInteger result = 1;

        for (int i = 2; i <= factorial; i++)
        {
            result = result * i;
        }

        Console.WriteLine(result);
    }
}

