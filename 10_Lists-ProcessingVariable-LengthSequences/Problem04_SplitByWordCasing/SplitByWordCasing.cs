using System;
using System.Collections.Generic;
using System.Linq;

class SplitByWordCasing
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> sequenceOfWords = input.Split(new char[] { ',', ';',  ':',
        '.', '!', '(',  ')',  '"','\'', '\\' , '/', '[', ']', ' ' }).ToList();
        PutWordsInCases(sequenceOfWords); // also it will call the result metod
    }

    public static void PutWordsInCases(List<string> sequenceOfWords)
    {
        string allLowerCaseWords = "";
        string allMixedCaseWords = "";
        string allUpperCaseWords = "";

        bool IsItLowerCase = false;
        bool isItUpperCase = false;

        string word = "";

        for (int i = 0; i < sequenceOfWords.Count; i++)
        {
            word = sequenceOfWords[i];

            for (int p = 0; p < word.Length; p++)
            {
                char symbol = word[p];

                if (symbol >= 65 && symbol <= 90)
                {
                    isItUpperCase = true;
                }

                else if (symbol >= 97 && symbol <= 122)
                {
                    IsItLowerCase = true;
                }

                else
                {
                    IsItLowerCase = true;
                    isItUpperCase = true;
                }
            }

            if (isItUpperCase == true && IsItLowerCase == false)
            {
                allUpperCaseWords += word + "," + " ";
            }

            if (isItUpperCase == false && IsItLowerCase == true)
            {
                allLowerCaseWords += word + "," + " ";
            }

            if (isItUpperCase == true && IsItLowerCase == true)
            {
                allMixedCaseWords += word + "," + " ";
            }

            IsItLowerCase = false;
            isItUpperCase = false;
        }
        PrintResult(allLowerCaseWords, allMixedCaseWords, allUpperCaseWords);
    }

    public static void PrintResult(string lowerCaseWords, string mixedCaseWords, string upperCaseWords)
    {
        lowerCaseWords = lowerCaseWords.Remove(lowerCaseWords.Length - 2); // remove the last not needed comma
        mixedCaseWords = mixedCaseWords.Remove(mixedCaseWords.Length - 2);
        upperCaseWords = upperCaseWords.Remove(upperCaseWords.Length - 2);

        Console.WriteLine("Lower-case: " + lowerCaseWords);
        Console.WriteLine("Mixed-case: " + mixedCaseWords);
        Console.WriteLine("Upper-case: " + upperCaseWords);
    }
}

