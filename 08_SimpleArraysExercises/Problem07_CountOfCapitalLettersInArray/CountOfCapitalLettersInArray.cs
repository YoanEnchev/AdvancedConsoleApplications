using System;

class CountOfCapitalLettersInArray
{
    static void Main()
    {
        string elements = Console.ReadLine();
        string[] checkForCapitalLetters = elements.Split(' ');
        int counter = 0;

        for (int i = 0; i < checkForCapitalLetters.Length; i++)
        {
            string element = checkForCapitalLetters[i];
            char elementFirstLetter = element[0];
            if (elementFirstLetter >= 65 && elementFirstLetter <= 90)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

