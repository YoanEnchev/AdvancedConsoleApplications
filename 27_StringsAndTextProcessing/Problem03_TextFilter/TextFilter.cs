using System;
using System.Collections.Generic;
using System.Linq;

class TextFilter
{
    static void Main()
    {
        string bannedWords_string = Console.ReadLine();
        string text = Console.ReadLine();

        string[] bannedWords = bannedWords_string
             .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
             .ToArray();

        for (int i = 0; i < bannedWords.Length; i++)
        {
            text =  text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
        }

        Console.WriteLine(text);
    }
}

