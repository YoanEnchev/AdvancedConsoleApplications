using System;
using System.Collections.Generic;
using System.Linq;

class RecordUniqueNames
{
    static void Main()
    {
        int howMany = int.Parse(Console.ReadLine());
        HashSet<string> uniqueNames = new HashSet<string>();

        for (int i = 0; i < howMany; i++)
        {
            uniqueNames.Add(Console.ReadLine());
        }

        PrintUniqueNames(uniqueNames);
    }

    public static void PrintUniqueNames(HashSet<string> uniqueNames)
    {
        Console.WriteLine(string.Join(Environment.NewLine, uniqueNames));
    }
}

