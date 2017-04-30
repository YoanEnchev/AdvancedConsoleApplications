using System;
using System.Collections.Generic;
using System.Linq;

public class DefaultValues
{
    public static void Main()
    {
        string input = Console.ReadLine();

        var everyKeyAndValue = new Dictionary<string, string>();
        var valueIsNull = new Dictionary<string, string>(); // "null" != null
        var valueIsNotNull = new Dictionary<string, string>();

        while (input != "end")
        {
            string[] keyAndValue = input.Split(' ');
            string key = keyAndValue[0];
            string value = keyAndValue[2];

            everyKeyAndValue[key] = value;

            input = Console.ReadLine();
        }

        string defaultValue = Console.ReadLine();

        foreach (var kvp in everyKeyAndValue)
        {
            if (kvp.Value != "null")
            {
                valueIsNotNull[kvp.Key] = kvp.Value;
            }

            else
            {
                valueIsNull[kvp.Key] = kvp.Value;
            }
        }
        var DicWithNewValue = valueIsNull
            .ToDictionary(x => x.Key, u => defaultValue);

        SortAndPrintResult(valueIsNotNull, DicWithNewValue);
    }

    public static void SortAndPrintResult(Dictionary<string, string> valueIsNotNull, Dictionary<string, string> DicWithNewValue)
    {
        var Ordered = valueIsNotNull
            .OrderBy(x => x.Value.Length)
            .Reverse();

        foreach (var kvp in Ordered)
        {
            Console.WriteLine(kvp.Key + " <-> " + kvp.Value);
        }

        foreach (var kvp in DicWithNewValue) // was "null"
        {
            Console.WriteLine(kvp.Key + " <-> " + kvp.Value);
        }

    }
}

