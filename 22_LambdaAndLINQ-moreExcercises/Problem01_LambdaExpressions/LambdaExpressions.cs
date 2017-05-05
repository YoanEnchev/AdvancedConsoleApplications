using System;
using System.Collections.Generic;
using System.Linq;

class LambdaExpressions
{
    static void Main()
    {
        string input = Console.ReadLine();
        var selectors_objectsAndProperties = new Dictionary<string, Dictionary<string, string>>();   

        while (input != "lambada")
        {
            if (input != "dance")
            {
                List<string> selector_objectAndProperty = input.Split(' ', '.').ToList();

                string selector = selector_objectAndProperty[0];
                string object_ = selector_objectAndProperty[2];
                string property = selector_objectAndProperty[3];

                if (!selectors_objectsAndProperties.ContainsKey(selector))
                {
                    selectors_objectsAndProperties[selector] = new Dictionary<string, string>();
                }

                selectors_objectsAndProperties[selector][object_] = property;
            }

            else
            {
                selectors_objectsAndProperties = selectors_objectsAndProperties
                    .ToDictionary(selector => selector.Key, objectsAndProperties => objectsAndProperties.Value
                    .ToDictionary(object_ => object_.Key, DancePartAndproperty => DancePartAndproperty.Key + "." + DancePartAndproperty.Value)); //!
            }

            input = Console.ReadLine();
        }

        PrintResult(selectors_objectsAndProperties);
    }

    public static void PrintResult(Dictionary<string, Dictionary<string, string>> selectors_objectsAndProperties)
    {
        foreach (var kvp in selectors_objectsAndProperties)
        {
            Console.Write($"{kvp.Key} => ");

            Dictionary<string, string> objectAndProperty = kvp.Value;

            foreach (var elements in objectAndProperty)
            {
                Console.WriteLine($"{elements.Key}.{elements.Value}");
            }
        }
    }
}

