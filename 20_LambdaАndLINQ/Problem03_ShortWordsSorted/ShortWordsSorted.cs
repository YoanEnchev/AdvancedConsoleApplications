using System;
using System.Collections.Generic;
using System.Linq;

public class ShortWordsSorted
{
    public static void Main()
    {
        var words = Console.ReadLine()
           .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '!', '?', ' ', '/', '\\', '\"', '\'' },
            StringSplitOptions.RemoveEmptyEntries)
           .Select(word => word.ToLower())
           .Where(word => word.Length < 5)
           .OrderBy(n => n)
           .Distinct();

        Console.WriteLine(string.Join(", ", words));
    }
}

