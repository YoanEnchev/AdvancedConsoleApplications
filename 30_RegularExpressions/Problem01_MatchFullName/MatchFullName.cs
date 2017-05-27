using System;
using System.Text.RegularExpressions;

class MatchFullName
{
    static void Main()
    {
        string pattern = @"\b[A-Z][a-z]+\ [A-Z][a-z]+\b";
        string input = Console.ReadLine();

        MatchCollection matchingWords = Regex.Matches(input, pattern);

        for (int i = 0; i < matchingWords.Count; i++)
        {
            Console.WriteLine(matchingWords[i]);
        }
    }
}

