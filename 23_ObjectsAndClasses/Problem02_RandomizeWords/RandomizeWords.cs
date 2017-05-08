using System;
using System.Collections.Generic;
using System.Linq;

class RandomizeWords
{
    static void Main()
    {
        var words = Console.ReadLine()
            .Split(' ')
            .ToArray();

        var rnd = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            int randomPosition = rnd.Next(0, words.Length);
            string currentWord = words[i];

            string randomWord = words[randomPosition];
            words[randomPosition] = currentWord; // swap
            words[i] = randomWord;
        }

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}

