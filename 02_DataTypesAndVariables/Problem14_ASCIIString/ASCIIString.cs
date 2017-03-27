using System;

class ASCIIString
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = "";

        for (int i = 1; i <= n; i++)
        {
            int ascii = int.Parse(Console.ReadLine());
            char converted = (char)ascii;
            result += converted;
        }
        Console.WriteLine(result);
    }
}

