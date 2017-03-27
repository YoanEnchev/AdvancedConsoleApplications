using System;

class DistanceOfTheStars
{
    static void Main()
    {
        decimal oneLightYear = 9450000000000m;
        Console.WriteLine("{0:#.##e+000}", (decimal)4.22 * oneLightYear);
        Console.WriteLine("{0:#.##e+000}", 26000 * oneLightYear);
        Console.WriteLine("{0:#.##e+000}", 100000 * oneLightYear);
        Console.WriteLine("{0:0.00e+000}", 46500000000 * oneLightYear);
    }
}

