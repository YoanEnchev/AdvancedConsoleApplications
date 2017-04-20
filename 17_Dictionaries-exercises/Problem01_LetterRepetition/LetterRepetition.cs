using System;
using System.Collections.Generic;
using System.Linq;

class LetterRepetition
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        Dictionary<char, int> symbolAndOccurance = new Dictionary<char, int>();

        for (int i = 0; i < sequence.Length; i++)
        {
            int occurance = HowManyTimesSymbolOccurs(sequence, sequence[i]);
            symbolAndOccurance[sequence[i]] = occurance;
        }

        PrintResult(symbolAndOccurance);
    }

    public static void PrintResult(Dictionary<char, int> symbolAndOccurance)
    {
        foreach (var item in symbolAndOccurance)
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }

    public static int HowManyTimesSymbolOccurs(string sequence, char currentSymbol)
    {
        int occurance = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (currentSymbol == sequence[i])
            {
                occurance++;
            }
        }

        return occurance;
    }
}

