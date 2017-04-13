using System;
using System.Collections.Generic;
using System.Linq;

class AverageCharacterDelimiter
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        List<string> elements = sequence.Split(' ').ToList();

        int[] sumAndCount = FindSumOfCharactersAndHowManyAre(elements);
        int sum = sumAndCount[0];
        int count = sumAndCount[1];

        int average = sum / count;
        char delimiter = (char)average;

        delimiter = UpperCaseIfItIsALetter(delimiter);
        PrintResult(elements, delimiter);
    }

    public static void PrintResult(List<string> elements, char delimiter)
    {
        for (int i = 0; i < elements.Count; i++)
        {
            if (i != elements.Count - 1)
            {
                Console.Write(elements[i] + delimiter);
            }

            else
            {
                Console.Write(elements[i]);
            }
        }
    }

    public static char UpperCaseIfItIsALetter(char delimiter)
    {
        if (delimiter >= 97 && delimiter <= 122)
        {
            int upperCase = delimiter - 32; // because of ASCII
            delimiter = (char)upperCase;
        }

        return delimiter;
    }

    public static int[] FindSumOfCharactersAndHowManyAre(List<string> elements)
    {
        int sumOfCharacters = 0;
        int countAllCharacters = 0;

        for (int i = 0; i < elements.Count; i++)
        {
            for (int p = 0; p < elements[i].Length; p++)
            {
                char symbol = elements[i][p];

                sumOfCharacters += symbol;
                countAllCharacters++;
            }
        }

        int[] sumAndCount = new int[2];
        sumAndCount[0] = sumOfCharacters;
        sumAndCount[1] = countAllCharacters;
        return sumAndCount;
    }
}

