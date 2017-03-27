using System;

class PrintingTriangle
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        PrintTriangle(number);
    }

    static void PrintTriangle(int n)
    {
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }

        for (int row = n - 1; row >= 1; row--)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }
    }
}

