using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class WordCount
{
    static void Main()
    {
        List<string> allWords = File
            .ReadAllText("03. Word Count/text.txt")
            .Split(new[] { ' ', ',', '.', '\n', '\r', '-' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList()
            .ConvertAll(x => x.ToLower());

        List<string> specificWords = File
            .ReadAllText("03. Word Count/words.txt")
            .Split(' ')
            .ToList();

        Dictionary<string, int> wordAndOccurance = new Dictionary<string, int>();

        for (int i = 0; i < specificWords.Count; i++)
        {
            int occurance = 0;
            for (int p = 0; p < allWords.Count; p++)
            {
                if (specificWords[i] == allWords[p])
                {
                    occurance++;
                }
            }
            wordAndOccurance[specificWords[i]] = occurance;
        }

        wordAndOccurance = wordAndOccurance
            .OrderByDescending(x => x.Value)
            .ToDictionary(y => y.Key, z => z.Value);

        foreach (var kvp in wordAndOccurance)
        {
            File.AppendAllText("03. Word Count/words occurance.txt", $"{kvp.Key} - {kvp.Value}");
            File.AppendAllText("03. Word Count/words occurance.txt", Environment.NewLine);
        }
    }
}

