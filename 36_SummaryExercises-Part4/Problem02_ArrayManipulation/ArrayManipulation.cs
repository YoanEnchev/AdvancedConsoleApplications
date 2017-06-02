using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulation
{
    static void Main()
    {
        int[] array = Console.ReadLine()
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToArray();

        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] tokens = command.Split(' '); ///
            string operation = tokens[0];

            if (operation == "exchange") // exc n = length - 1
            {
                array = ChangeSides(array, tokens);
            }

            if (operation == "max")
            {
                PrintMax(array, tokens);
            }

            if (operation == "min")
            {
                PrintMin(array, tokens);
            }

            if (operation == "first")
            {
                PrintSpecificFirstElements(array, tokens);
            }

            if (operation == "last")
            {
                PrintSpecificLastElements(array, tokens);
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"[{string.Join(", ",array)}]");
    }

    public static void PrintSpecificLastElements(int[] array, string[] tokens)
    {
        int count = int.Parse(tokens[1]);
        string oddOrEven = tokens[2];

        if (count <= array.Length)
        {
            if (oddOrEven == "odd")
            {
                int[] odds = array
                    .Where(x => x % 2 != 0)
                    .Take(count)
                    .ToArray();

                odds = odds
                    .Skip(odds.Length - count)
                    .Take(count)
                    .ToArray();

                Console.WriteLine($"[{string.Join(", ", odds)}]");
            }

            if (oddOrEven == "even")
            {
                int[] evens = array
                   .Where(x => x % 2 == 0)
                   .Take(count)
                   .ToArray();

                evens = evens
                    .Skip(evens.Length - count)
                    .Take(count)
                    .ToArray();

                Console.WriteLine($"[{string.Join(", ", evens)}]");
            }           
        }

        else
        {
            Console.WriteLine("Invalid count");
        }
    }

    public static void PrintSpecificFirstElements(int[] array, string[] tokens)
    {
        int count = int.Parse(tokens[1]);
        string oddOrEven = tokens[2];

        if (count <= array.Length)
        {
            if (oddOrEven == "odd")
            {
                int[] odds = array
                    .Where(x => x % 2 != 0)
                    .Take(count)
                    .ToArray();

                Console.WriteLine($"[{string.Join(", ", odds)}]");
            }

            if (oddOrEven == "even")
            {
                int[] evens = array
                    .Where(x => x % 2 == 0)
                    .Take(count)
                    .ToArray();

                Console.WriteLine($"[{string.Join(", ", evens)}]");
            }
        }

        else
        {
            Console.WriteLine("Invalid count");
        }
    }

    public static void PrintMin(int[] array, string[] tokens)
    {
        string oddOrEven = tokens[1];

        if (oddOrEven == "odd")
        {
            int minOdd = int.MaxValue;
            int minOdd_index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] <= minOdd)
                {
                    minOdd = array[i];
                    minOdd_index = i;
                }
            }

            if (minOdd_index != -1)
            {
                Console.WriteLine(minOdd_index);
            }

            else
            {
                Console.WriteLine("No matches");
            }
        }

        if (oddOrEven == "even")
        {
            int minEven = int.MaxValue;
            int minEven_index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] <= minEven)
                {
                    minEven = array[i];
                    minEven_index = i;
                }
            }

            if (minEven_index != -1)
            {
                Console.WriteLine(minEven_index);
            }

            else
            {
                Console.WriteLine("No matches");
            }
        }
    }

    public static void PrintMax(int[] array, string[] tokens)
    {
        string oddOrEven = tokens[1];

        if (oddOrEven == "odd")
        {
            int maxOdd = int.MinValue;
            int maxOdd_index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] >= maxOdd)
                {
                    maxOdd = array[i];
                    maxOdd_index = i;
                }
            }

            if (maxOdd_index != -1)
            {
                Console.WriteLine(maxOdd_index);
            }

            else
            {
                Console.WriteLine("No matches");
            }
        }

        if (oddOrEven == "even")
        {
            int maxEven = int.MinValue;
            int maxEven_index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] >= maxEven)
                {
                    maxEven = array[i];
                    maxEven_index = i;
                }
            }

            if (maxEven_index != -1)
            {
                Console.WriteLine(maxEven_index);
            }

            else
            {
                Console.WriteLine("No matches");
            }
        }
    }

    public static int[] ChangeSides(int[] array, string[] tokens)
    {
        int index = int.Parse(tokens[1]);

        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Invalid index");
        }

        else
        {
            int[] firstSide = array
                .Take(index + 1)
                .ToArray();

            int[] secondSide = array
                .Skip(index + 1)
                .Take(500)
                .ToArray(); //all

            array = secondSide.Concat(firstSide).ToArray();
        }

        return array;
    }
}

