using System;

class TrickyStrings
{
    static void Main()
    {
        string delimiter = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string rememberTheString = "";
        string result = "";
        for (int i = 1; i <= n; i++)
        {
            rememberTheString = Console.ReadLine();
            result += rememberTheString;
            if (i != n)
            {
                result += delimiter;
            }
        }
        Console.WriteLine(result);
    }
}

