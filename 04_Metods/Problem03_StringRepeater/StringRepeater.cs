using System;

class StringRepeater
{
    static void Main()
    {
        string ToBeRepeated = Console.ReadLine();
        int HowMuchTimeToRepeat = int.Parse(Console.ReadLine());

        Console.WriteLine(StringRepeat(ToBeRepeated, HowMuchTimeToRepeat));
    }
    static string StringRepeat(string wordToRepeat, int count)
    {
        string result = "";
        for (int i = 1; i <= count; i++)
        {
            result += wordToRepeat;
        }
        return result;
    }
}

