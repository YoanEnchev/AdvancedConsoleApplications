using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Palindromes
{
    static void Main()
    {
        string input = Console.ReadLine();
        var palindromes = new List<string>();

        string[] words = input
            .Split(new[] { ',', '.', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            List<string> everyLetterReversed_List = GetEveryLetterAndPutItInList(word);
            string reversed = string.Join("", everyLetterReversed_List);

            if (word == reversed)
            {
                palindromes.Add(word);
            }

            palindromes.Sort();
        }

        HashSet<string> uniqueOnly = GetUniqueWords(palindromes);
        Console.WriteLine(string.Join(", ", uniqueOnly));
    }

    public static HashSet<string> GetUniqueWords(List<string> palindromes)
    {
        HashSet<string> uniques = new HashSet<string>();

        for (int i = 0; i < palindromes.Count; i++)
        {
            uniques.Add(palindromes[i]);
        }

        return uniques;
    }

    public static List<string> GetEveryLetterAndPutItInList(string word)
    {
        List<string> symbols = new List<string>();

        for (int i = word.Length - 1; i >= 0; i--)
        {
            string symbol = word[i].ToString();
            symbols.Add(symbol);
        }

        return symbols;
    }
}

