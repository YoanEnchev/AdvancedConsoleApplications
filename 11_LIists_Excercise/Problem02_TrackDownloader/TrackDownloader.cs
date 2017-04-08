using System;
using System.Collections.Generic;
using System.Linq;

class TrackDownloader
{
    static void Main()
    {
        List<string> blackListedWords = Console.ReadLine().Split(' ').ToList();

        string song = "";
        List<string> songNames = new List<string>();
        List<string> result = new List<string>();

        while (song != "end")
        {
            song = Console.ReadLine();
            if (song != "end") // in order end to not be taken as song
            {
                song = CheckIfSongIsBlacklisted(song, blackListedWords);

                if (song != "Blacklisted")
                {
                    result.Add(song);
                }
            }
        }
        result.Sort();
        PrintResult(result);
    }

    public static void PrintResult(List<string> result)
    {
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

    public static string CheckIfSongIsBlacklisted(string song, List<string> blackListedWords)
    {
        bool isItBlacklisted = false;
        for (int i = 0; i < blackListedWords.Count; i++)
        {
            if (song.Contains(blackListedWords[i]))
            {
                isItBlacklisted = true;
            }
        }

        if (isItBlacklisted == true)
        {
            song = "Blacklisted"; //is not going to be printed
        }
        return song;
    }
}

