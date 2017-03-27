using System;

class TriangleFormations
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int BiggestSide = 0;
        int NotBiggestSideOne = 0;
        int NotBiggestSideTwo = 0;

        if (a >= b && a >= c)
        {
            BiggestSide = a;
            NotBiggestSideOne = b;
            NotBiggestSideTwo = c;
        }

        else if (b >= a && b >= c)
        {
            BiggestSide = b;
            NotBiggestSideOne = a;
            NotBiggestSideTwo = c;
        }

        else if (c >= a && c >= b)
        {
            BiggestSide = c;
            NotBiggestSideOne = b;
            NotBiggestSideTwo = a;
        }

        if (BiggestSide < NotBiggestSideOne + NotBiggestSideTwo)
        {
            Console.WriteLine("Triangle is valid.");
            if (BiggestSide * BiggestSide == NotBiggestSideOne * NotBiggestSideOne + NotBiggestSideTwo * NotBiggestSideTwo)
            {
                Console.Write("Triangle has a right angle ");
                if (BiggestSide == c)
                {
                    Console.Write("between sides a and b");
                }

                if (BiggestSide == b)
                {
                    Console.Write("between sides a and c");
                }

                if (BiggestSide == a)
                {
                    Console.Write("between sides b and c");
                }
            }
            else
            {
                Console.WriteLine("Triangle has no right angles");
            }
        }
        else
        {
            Console.WriteLine("Invalid Triangle.");
        }
    }
}

