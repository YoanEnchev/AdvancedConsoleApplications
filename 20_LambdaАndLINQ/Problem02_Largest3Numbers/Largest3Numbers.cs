using System;
using System.Collections.Generic;
using System.Linq;

class Largest3Numbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ')
            .Select(int.Parse)
            .ToList();

        var takeBiggestThreeNumbers = numbers
            .OrderByDescending(n => n)
            .Take(3);

        Console.WriteLine(string.Join(" ", takeBiggestThreeNumbers));
    }
}

