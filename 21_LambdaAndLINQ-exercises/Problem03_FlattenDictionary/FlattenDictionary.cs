using System;
using System.Collections.Generic;
using System.Linq;

public class FlattenDictionary
{
    public static void Main()
    {
        string input = Console.ReadLine();
        var keys_innerKeys_innerValues = new Dictionary<string, Dictionary<string, string>>();

        string key = "";
        string innerKey = "";
        string innerValue = "";
        string keyToBeFlatten = "";

        var Flatten_keys_innerKeys_innerValues = new Dictionary<string, Dictionary<string, string>>();

        while (input != "end")
        {
            string[] key_innerKey_innerValue = input.Split(' ');

            if (key_innerKey_innerValue[0] == "flatten")
            {
                keyToBeFlatten = key_innerKey_innerValue[1];

                Flatten_keys_innerKeys_innerValues[keyToBeFlatten] = keys_innerKeys_innerValues[keyToBeFlatten];

                if (keys_innerKeys_innerValues.ContainsKey(keyToBeFlatten))
                {
                    keys_innerKeys_innerValues.Remove(keyToBeFlatten); // ... = ?
                }
            }

            else
            {
                key = key_innerKey_innerValue[0];
                innerKey = key_innerKey_innerValue[1];
                innerValue = key_innerKey_innerValue[2];

                if (!keys_innerKeys_innerValues.ContainsKey(key))
                {
                    keys_innerKeys_innerValues[key] = new Dictionary<string, string>();
                }

                keys_innerKeys_innerValues[key][innerKey] = innerValue;
            }

            input = Console.ReadLine();
        }

        SortDictionariesAndPrintResult(keys_innerKeys_innerValues, Flatten_keys_innerKeys_innerValues);
    }

    public static void SortDictionariesAndPrintResult(Dictionary<string, Dictionary<string, string>> keys_innerKeys_innerValues,
         Dictionary<string, Dictionary<string, string>> flatten_keys_innerKeys_innerValues)
    {
        var order = keys_innerKeys_innerValues // for keys
              .OrderByDescending(x => x.Key.Length)
              .ToDictionary(x => x.Key, y => y.Value);

        var flattenOrderedByInput = flatten_keys_innerKeys_innerValues
            .Reverse()
            .ToDictionary(x => x.Key, y => y.Value);

        foreach (var kvp in order)
        {
            int index = 1;
            string key = kvp.Key;
            var innerKeyAndValue = kvp
                .Value.
                OrderBy(x => x.Key.Length);

            Console.WriteLine(key);

            foreach (var item in innerKeyAndValue)
            {
                Console.WriteLine($"{index}. {item.Key} - {item.Value}");
                index++;
            }

            foreach (var Key_and_flattenInnerValuesAndPairs in flattenOrderedByInput)
            {
                var flattenInnerValuesAndPairs = Key_and_flattenInnerValuesAndPairs.Value;

                if (Key_and_flattenInnerValuesAndPairs.Key == key)
                {
                    foreach (var currentFlattenInnerValuesAndPairs in flattenInnerValuesAndPairs)
                    {
                        Console.WriteLine($"{index}. {currentFlattenInnerValuesAndPairs.Key}{currentFlattenInnerValuesAndPairs.Value}");
                        index++;
                    }

                }
            }
        }
    }
}
