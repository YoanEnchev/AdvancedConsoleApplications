using System;

class FromTerabytesToBits
{
    static void Main()
    {
        decimal TB = decimal.Parse(Console.ReadLine());
        decimal b = TB * 1024 * 1024 * 1024 * 1024 * 8m;
        Console.WriteLine("{0:0}", b);
    }
}

