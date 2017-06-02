using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
//score: 80/100

class WormIpsum
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern_validSentence = @"^([A-Z])([^.?!])*([.?!])+$";

        while (input != "Worm Ipsum")
        {
            bool validSentence = Regex.IsMatch(input, pattern_validSentence);

            if (validSentence)
            {
                string sentence = input;
                char lastCharacter = sentence[sentence.Length - 1];
                sentence = ReplaceLastSymbolWithSpace(sentence);

                sentence = ChangeWordIfNeeded(sentence);
                Console.WriteLine(sentence + lastCharacter);                    
            }
                     
            input = Console.ReadLine();
        }
    }

    public static string ChangeWordIfNeeded(string sentence)
    {
        string copyOfSentence = sentence;

        while(copyOfSentence.ToString().Length != 0)
        {
            int index = copyOfSentence.IndexOf(' ', ',',':');
            Dictionary<char, int> characterOccurance = new Dictionary<char, int>();

            string word = copyOfSentence.Substring(0, index);

            string changedWord = word;

            if (word == "")
            {
                break;
            }

            for (int w = 0; w < word.Length; w++)
            {
                char currentSymbol = word[w];

                if (!characterOccurance.ContainsKey(currentSymbol)) //ToLower?
                {
                    characterOccurance[currentSymbol] = 1;
                }

                else
                {
                    characterOccurance[currentSymbol]++;
                }
            }

            characterOccurance = characterOccurance
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            char mostOccuredChar = characterOccurance.First().Key;
            int max = characterOccurance.First().Value;

            if (max > 1)
            {
                changedWord = new string(mostOccuredChar, word.Length);
                sentence = sentence.Replace(word,changedWord);
            }

            copyOfSentence = copyOfSentence.Remove(0, word.Length + 1);
        }

        sentence = sentence.Remove(sentence.Length - 1, 1); //remove last space
        return sentence;
    }

    public static string ReplaceLastSymbolWithSpace(string sentence)
    {
        char last = sentence.Last();

        sentence =  sentence.Replace(last, ' ');

        return sentence;
    }

}

