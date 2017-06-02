using System;
using System.Collections.Generic;
using System.Linq;

class SoftuniKaraoke
{
    static void Main()
    {
        List<string> names = Console.ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .ToList();

        List<string> singerAndSongAvaliable = Console.ReadLine()
            .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToList();

        string karaokeSingesongAndAward = Console.ReadLine();
        var karaokeSingerNameAndAwards = new Dictionary<string, HashSet<string>>();

        while (karaokeSingesongAndAward != "dawn")
        {
            string[] tokens = karaokeSingesongAndAward
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            string singer = tokens[0];
            string famousSingerAndSong = tokens[1];
            string award = tokens[2];

            bool singerRegistered = false;
            bool famousSingerAndSongRegistered = false;

            if (names.Contains(singer))
            {
                singerRegistered = true;
            }

            if (singerAndSongAvaliable.Contains(famousSingerAndSong))
            {
                famousSingerAndSongRegistered = true;
            }

            if (singerRegistered && famousSingerAndSongRegistered)
            {
                if (!karaokeSingerNameAndAwards.ContainsKey(singer))
                {
                    karaokeSingerNameAndAwards[singer] = new HashSet<string>();
                }

                karaokeSingerNameAndAwards[singer].Add(award);
            }

            karaokeSingesongAndAward = Console.ReadLine();
        }

        if (karaokeSingerNameAndAwards.Count == 0)
        {
            Console.WriteLine("No awards");
        }

        else
        {
            SortAndPrintResult(karaokeSingerNameAndAwards);
        }
    }

    public static void SortAndPrintResult(Dictionary<string, HashSet<string>> karaokeSingerNameAndAwards)
    {
        karaokeSingerNameAndAwards = karaokeSingerNameAndAwards
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(name => name.Key)
            .ToDictionary(y => y.Key, z => z.Value);

        foreach (var kvp in karaokeSingerNameAndAwards)
        {
            string name = kvp.Key;
            HashSet<string> uniqueAwards_hashSet = kvp.Value;

            List<string> uniqueAwards = uniqueAwards_hashSet.ToList();
            uniqueAwards = uniqueAwards
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine($"{name}: {uniqueAwards.Count} awards");

            for (int i = 0; i < uniqueAwards.Count; i++)
            {
                Console.WriteLine($"--{uniqueAwards[i]}");
            }
        }
    }
}

