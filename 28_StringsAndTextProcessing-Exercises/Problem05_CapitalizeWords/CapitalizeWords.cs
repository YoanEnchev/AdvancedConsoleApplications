using System;
using System.Collections.Generic;
using System.Linq;

class CapitalizeWords
{
    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            input = input.ToLower();

            string[] words = input
                .Split(new[] { ' ', ',', '?', '!', '.', ':', '%', '|', '$', '#', '@', '(', ')', '[', ']', '{', '}', '+', '-', '*', '/', '\\', '>', '<', '=' }
            , StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string firstLetter_Capitalized = words[i][0]
                    .ToString()
                    .ToUpper();

                string word_WithoutFirstLetter = words[i].Remove(0, 1); // remove first letter

                words[i] = firstLetter_Capitalized + word_WithoutFirstLetter;
            }

            Console.WriteLine(string.Join(", ", words));
            input = Console.ReadLine();
        }
    }
}
