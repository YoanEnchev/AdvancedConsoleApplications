using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class HappinessIndex
{
   public static void Main()
    {
        string happinesPattern = @":\)|:D|;\)|:\*|:]|;]|:}|;}|\(:|\*:|c:|\[:|\[;";
        string sadnessPatern = @":\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|]:|];";

        string input = Console.ReadLine();
        MatchCollection happyEmoticons = Regex.Matches(input, happinesPattern);
        MatchCollection sadEmoticons = Regex.Matches(input, sadnessPatern);

        double happyCount = happyEmoticons.Count;
        double sadCount = sadEmoticons.Count;
        double happinessIndex = happyCount / sadCount;

        string emoticonForHappinessIndex = Categorize(happinessIndex);
        PrintResult(happyCount, sadCount, happinessIndex, emoticonForHappinessIndex);
    }

    public static void PrintResult(double happyCount, double sadCount, double happinessIndex, string emoticonForHappinessIndex)
    {
        Console.WriteLine($"Happiness index: {happinessIndex:F2} {emoticonForHappinessIndex}");
        Console.Write($"[Happy count: {happyCount}, Sad count: {sadCount}]");
    }

    public static string Categorize(double happinessIndex)
    {
        string emoticon = "";

        if(happinessIndex >= 2)
        {
            emoticon = ":D";
        }

        else if(happinessIndex > 1)
        {
            emoticon = ":)";
        }

        else if(happinessIndex == 1)
        {
            emoticon = ":|";
        }

        else if(happinessIndex < 1)
        {
            emoticon = ":(";
        }

        return emoticon;
    }
}

