using System;

class DrawAFilledSquare
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintHeader(n);
        Middle(n);
        PrintHeader(n); //Footer

    }

    static void PrintHeader(int number)
    {
        for (int i = 1; i <= 2 * number; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }

    static void Middle(int number)
    {
        for (int row = 1; row <= number - 2; row++)
        {
            for (int col = 1; col <= 2 * number; col++)
            {
                Console.Write("-");
                col++;
                while (col <= (number * 2) - 2)
                {
                    Console.Write(@"\/");
                    col = col + 2;
                }
                Console.Write("-");
                col++;
            }
            Console.WriteLine();
        }
    }
}


