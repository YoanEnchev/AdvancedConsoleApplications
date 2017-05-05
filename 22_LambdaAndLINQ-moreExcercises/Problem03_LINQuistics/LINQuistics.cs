using System;
using System.Collections.Generic;
using System.Linq;


public class LINQuistics
{
    public static void Main()
    {
        string input = Console.ReadLine();
        var collectionsAndMethods = new Dictionary<string, List<string>>();

        while (input != "exit")
        {
            var collectionAndMetods = input
              .Split(new[] { '.', '(', ')' },
               StringSplitOptions.RemoveEmptyEntries)
              .Distinct() 
              .ToList();

            string collection_ = collectionAndMetods[0];

            if (collectionAndMetods.Count == 1)
            {
                if (collectionsAndMethods.ContainsKey(collection_))
                {               
                    PrintMetodsOfColectionOrdered(collectionsAndMethods[collection_]);
                }

                int digit;
                bool successfullyParsed = int.TryParse(collection_, out digit);

                if (successfullyParsed)
                {
                    var hasMostElements = collectionsAndMethods
                        .Values
                        .OrderByDescending(x => x.Count)
                        .ToList();

                    List<string> metodsOfHasMostElements = hasMostElements[0];
                    metodsOfHasMostElements.Reverse();

                    digit = int.Parse(collection_);

                        var onlyTreeMetods = metodsOfHasMostElements
                            .Take(digit)
                            .ToList();
                    
                    PrintMetodsOfColectionThatHasTheMost(onlyTreeMetods);
                }

                while (true)
                {
                    break;
                }
            }
            var metods = collectionAndMetods
             .Skip(1)
             .Take(collectionAndMetods.Count - 1)
             .ToList();


            if (!collectionsAndMethods.ContainsKey(collection_))
            {
                collectionsAndMethods[collection_] = new List<string>();
            }

            collectionsAndMethods[collection_] = collectionsAndMethods[collection_]
                .Concat(metods)
                .Distinct()
                .OrderByDescending(x => x.Length)
                .ToList();

            input = Console.ReadLine();
        }
        var metodAndCollection = Console.ReadLine().Split(' ');

        string metod = metodAndCollection[0];
        string collection = metodAndCollection[1];

        var badKeys = collectionsAndMethods
            .Where(pair => pair.Value.Count == 0)
            .Select(pair => pair.Key)
            .ToList();

        foreach (var badKey in badKeys)
        {
            collectionsAndMethods.Remove(badKey);
        }

        collectionsAndMethods = collectionsAndMethods
            .OrderByDescending(x => x.Value.Count)
            .ThenByDescending(kvp => kvp.Value.Min(str => str.Length))
            .ToDictionary(y => y.Key, z => z.Value);


        if (collection == "collection")
        {
            PrintOnlyNames(collectionsAndMethods, metod);
        }

        if (collection == "all")
        {
            PrintNamesAndMetods(collectionsAndMethods, metod);
        }
    }

    public static void PrintNamesAndMetods(Dictionary<string, List<string>> collectionsAndMethods, string metod)
    {

        foreach (var kvp in collectionsAndMethods.OrderByDescending(x => x.Value.Count))
        {
            List<string> metods = kvp.Value;

            if (metods.Contains(metod))
            {
                Console.WriteLine(kvp.Key);
            }

            foreach (var function in metods)
            {
                Console.WriteLine("* " + function);
            }
        }
    }

    public static void PrintOnlyNames(Dictionary<string, List<string>> collectionsAndMethods, string metod)
    {
        
        foreach (var kvp in collectionsAndMethods)
        {
            List<string> metods = kvp.Value;

            if (metods.Contains(metod))
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }

    public static void PrintMetodsOfColectionThatHasTheMost(List<string> hasMostElements)
    {
        foreach (var metod in hasMostElements.OrderByDescending(x => x.Length)
               .ThenByDescending(x => x.Distinct().Count())
               .Reverse())
        {
            Console.WriteLine("* " + metod);
        }
    }
    
    public static void PrintMetodsOfColectionOrdered(List<string> metods)
    {
        foreach (var metod in metods.OrderByDescending(x => x.Length)
                       .ThenByDescending(x => x.Distinct().Count()))
        {
            Console.WriteLine("* " + metod);
        }
    }
}