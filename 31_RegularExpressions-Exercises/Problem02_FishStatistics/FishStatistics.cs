using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class FishStatistics
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @">*<\(+(\'|x|-)>";

        MatchCollection matches = Regex.Matches(input, pattern);

        if (matches.Count == 0)
        {
            Console.WriteLine("No fish found.");
        }

        else
        {
            List<string> fishes = ConvertToList(matches);

            for (int i = 0; i < fishes.Count; i++)
            {
                Fish currentFish = GetInfo(fishes[i]);
                PrintDataAndCategorizeSizes(currentFish, fishes[i], i);
            }
        }
    }

    public static void PrintDataAndCategorizeSizes(Fish currentFish, string fish, int index)
    {
        Console.WriteLine($"Fish {index + 1}: {fish}");

        string tailCategory = "";
        string bodyCategory = "";

        if(currentFish.tail > 5)
        {
            tailCategory = "Long";
        }

        if(currentFish.tail <= 5 && currentFish.tail > 1) // <=?
        {
            tailCategory = "Medium";
        }

        if(currentFish.tail == 1)
        {
            tailCategory = "Short";
        }

        if(currentFish.tail == 0)
        {
            tailCategory = "None";
        }

        Console.Write($"  Tail type: {tailCategory} ");

        if(tailCategory != "None")
        {
            Console.WriteLine($"({currentFish.tail * 2} cm)");
        }

        else
        {
            Console.WriteLine();
        }

        if(currentFish.body > 10)
        {
            bodyCategory = "Long";
        }

        if(currentFish.body > 5 && currentFish.body <= 10)
        {
            bodyCategory = "Medium";
        }

        if(currentFish.body <= 5)
        {
            bodyCategory = "Short";
        }

        Console.WriteLine($"  Body type: {bodyCategory} ({currentFish.body * 2} cm)");
        Console.WriteLine($"  Status: {currentFish.status}");
    }

    public static Fish GetInfo(string fish)
    {
        int tail = 0;
        int body = 0;
        string status = "";

        for (int i = 0; i < fish.Length - 1; i++)
        {
            if(fish[i] == '>')
            {
                tail++;
            }

            if(fish[i] == '(')
            {
                body++;
            }

            if (fish[i] == '\'')
            {
                status = "Awake";
            }

            if(fish[i] == '-')
            {
                status = "Asleep";
            }
            
            if (fish[i] == 'x') // ||X
            {
                status = "Dead";
            }           
        }

        Fish currentFish = new Fish
        {
            tail = tail, //not in cm
            body = body,
            status = status
        };

        return currentFish;
    }

    public static List<string> ConvertToList(MatchCollection matches)
    {
        var fishes = new List<string>();

        for (int i = 0; i < matches.Count; i++)
        {
            fishes.Add(matches[i].ToString());
        }

        return fishes;
    }
}

