using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class WordEncounter
{
    static void Main()
    {
        string charAndNumber = Console.ReadLine();
        string allRegularSentences = "";

        char symbolToCheck = charAndNumber[0];
        int howManyTimes = int.Parse(charAndNumber[1] + "");

        string input = Console.ReadLine();

        while (input != "end")
        {
            if (input[0] == input.ToUpper()[0])
            {
                int last = input.Length - 1;

                if ((input[last] == '!') || (input[last] == '?') || (input[last] == '.'))
                {
                    allRegularSentences += input + " ";
                }
            }
            input = Console.ReadLine();
        }

        List<string> allWords = allRegularSentences
       .Split(new[] { '*', ' ', '.', '?', '!', ',', ':', '|', '\\', '/', ';', '(', ')', '{', '}', '[', ']' },
        StringSplitOptions.RemoveEmptyEntries) //more?
       .ToList();

        string patternForContainingLetter = GetPattern(howManyTimes, symbolToCheck);

        List<string> wordThatContainsLetterAtLeastNTimes = GetTheProperWords(patternForContainingLetter, allWords);
             
            Console.WriteLine(string.Join(", ", wordThatContainsLetterAtLeastNTimes));    
    }


    public static string GetPattern(int howManyTimes, char symbolToCheck)
    {
        string pattern = ".*";

        for (int i = 0; i < howManyTimes; i++)
        {
            pattern += symbolToCheck + ".*";
        }

        return pattern;
    }

    public static List<string> GetTheProperWords(string patternForContainingLetter, List<string> allWords)
    {
        List<string> properWords = new List<string>();

        for (int i = 0; i < allWords.Count; i++)
        {
            if (Regex.IsMatch(allWords[i], patternForContainingLetter))
            {
                properWords.Add(allWords[i]);
            }
        }

        return properWords;
    }
}


