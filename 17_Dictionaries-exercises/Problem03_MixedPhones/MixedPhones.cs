using System;
using System.Collections.Generic;
using System.Linq;

class MixedPhones
{
    static void Main()
    {
        string input = Console.ReadLine();
        SortedDictionary<string, long> SortednameAndNumber = new SortedDictionary<string, long>();

        while (input != "Over")
        {
            string[] nameAndPhone = input.Split(' ');

            string left = nameAndPhone[0];
            string right = nameAndPhone[2]; //[1] = ":" 

            string name = "";
            long phone;

            int firstSymbol = left[0];

            if (firstSymbol >= 48 && firstSymbol <= 57) // 0 - 9
            {
                phone = long.Parse(left);
                name = right;
            }

            else
            {
                phone = long.Parse(right);
                name = left;
            }

            SortednameAndNumber[name] = phone;
            input = Console.ReadLine();
        }

        PrintNamesAndPhones(SortednameAndNumber);
    }

    public static void PrintNamesAndPhones(SortedDictionary<string, long> nameAndNumber)
    {
        foreach (var item in nameAndNumber)
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}

