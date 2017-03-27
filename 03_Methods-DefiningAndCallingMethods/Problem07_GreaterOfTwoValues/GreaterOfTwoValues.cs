using System;

class GreaterOfTwoValues
{
    static void Main()
    {
        string type = Console.ReadLine();
        if (type == "int")
        {
            int First = int.Parse(Console.ReadLine());
            int Second = int.Parse(Console.ReadLine());
            Console.WriteLine(compare(First, Second));
        }

        if (type == "char")
        {
            char First = char.Parse(Console.ReadLine());
            char Second = char.Parse(Console.ReadLine());
            Console.WriteLine(compare(First, Second));
        }

        if (type == "string")
        {
            string First = Console.ReadLine();
            string Second = Console.ReadLine();
            Console.WriteLine(compare(First, Second));
        }
    }

    static int compare(int first, int second)
    {
        return Math.Max(first, second);
    }

    static char compare(char first, char second)
    {
        if (first > second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

    static string compare(string first, string second)
    {
        if (first.CompareTo(second) > 0)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}

