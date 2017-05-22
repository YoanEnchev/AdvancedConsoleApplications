using System;

class CountSubstringOccurance
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.ToLower();

        string repeaingString = Console.ReadLine();
        repeaingString = repeaingString.ToLower();

        int index = input.IndexOf(repeaingString);
        int howManyTimes = 0;

        while (index != -1)
        {
            index = input.IndexOf(repeaingString, index + 1);
            howManyTimes++;
        }

        Console.WriteLine(howManyTimes);
    }
}

