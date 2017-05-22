using System;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        string output = "";

        for (int i = input.Length - 1; i > -1; i--)
        {
            output += input[i];
        }

        Console.WriteLine(output);
    }
}

