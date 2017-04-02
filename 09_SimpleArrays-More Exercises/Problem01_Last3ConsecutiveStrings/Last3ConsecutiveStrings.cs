using System;

class Last3ConsecutiveStrings
{
    static void Main()
    {
        string words = Console.ReadLine();
        string[] lastThreeConsecutiveStrings = words.Split(' ');

        string previous = "";
        string current = "";
        string next = "";

        string result = "";

        for (int i = 0; i < lastThreeConsecutiveStrings.Length - 1; i++)
        {
            if (i != 0)
            {
                previous = lastThreeConsecutiveStrings[i - 1];
                current = lastThreeConsecutiveStrings[i];
                next = lastThreeConsecutiveStrings[i + 1];
            }

            if (previous == current && next == current && previous == next)
            {
                result = previous;
            }
        }

        Console.WriteLine(result + " " + result + " " + result);
    }
}

