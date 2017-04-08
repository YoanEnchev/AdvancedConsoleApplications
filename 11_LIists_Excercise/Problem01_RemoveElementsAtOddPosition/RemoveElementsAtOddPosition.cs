using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveElementsAtOddPosition
{
    public static void Main()
    {
        string sequenceOfWords = Console.ReadLine();
        List<string> words = sequenceOfWords.Split(' ').ToList();

        for (int i = 0; i < words.Count; i++)
        {
            if(i%2 == 1)
            {
                Console.Write(words[i]);
            }
        }
    }
}

