using System;

class ExactSumOfRealNumbers
{
    static void Main()
    {
        decimal sum = 0m;
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            sum += decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}

