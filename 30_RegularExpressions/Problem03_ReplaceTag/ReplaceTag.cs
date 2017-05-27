using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main()
    {
        string input = "";
        string newLine = "";

        string pattern = @"<ahref=.+?<\/a>";

        while (newLine != "end")
        {
            newLine = Console.ReadLine();

            if (newLine != "end")
            {
                input += newLine;
            }
        }

        MatchCollection tags = Regex.Matches(input, pattern);
        List<string> tags_string = ConvertToString(tags);

        List<string> replacedTags = new List<string>();

        for (int i = 0; i < tags_string.Count; i++)
        {
            string replacedTag = tags_string[i].Replace("<a", "[URL ");
            replacedTag = replacedTag.Replace("</a>", "[/URL]");
            replacedTag = replacedTag.Replace(">", "]");

            replacedTags.Add(replacedTag);
        }

        input = ReplaceOldTagsWithNew(input, tags_string, replacedTags);

        Console.WriteLine(input);
    }

    public static string ReplaceOldTagsWithNew(string input, List<string> tags_string, List<string> replacedTags)
    {
        for (int i = 0; i < tags_string.Count; i++)
        {
            input = input.Replace(tags_string[i], replacedTags[i]);
        }

        return input;
    }

    public static List<string> ConvertToString(MatchCollection tags)
    {
        List<string> tags_string = new List<string>();

        for (int i = 0; i < tags.Count; i++)
        {
            tags_string.Add(tags[i].ToString());
        }

        return tags_string;
    }
}

