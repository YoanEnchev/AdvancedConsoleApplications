using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//score: 100/100
//Exam score => 380/100
//grade: 5.80/6.00

class WormsWorldParty
{
    static void Main()
    {
        var teams = new Dictionary<string, List<Worm>>();

        string input = Console.ReadLine();

        while (input != "quit")
        {
            string[] tokens = input
                .Split(new[] { " -> " }, StringSplitOptions.None);

            string wormName = tokens[0];
            string team = tokens[1];
            long wormScore = long.Parse(tokens[2]);

            if (!teams.ContainsKey(team)) //not registered team
            {
                teams[team] = new List<Worm>();

                Worm wormToRegiser = new Worm
                {
                    name = wormName,
                    score = wormScore
                };

                teams[team].Add(wormToRegiser);
            }

            else //team registered
            {
                bool wormIsAlreadyInTeam = CheckIsTheNameRegistered(teams, wormName);

                if (wormIsAlreadyInTeam) //already registered, ignored
                {
                    break;
                }

                else //not registered teammate
                {
                    Worm wormToRegiser = new Worm
                    {
                        name = wormName,
                        score = wormScore
                    };

                    teams[team].Add(wormToRegiser);
                }
            }

            input = Console.ReadLine();
        }

        OrderAndPrintResult(teams);
    }

    public static void OrderAndPrintResult(Dictionary<string, List<Worm>> teams)
    {
        teams = teams
            .OrderByDescending(x => x.Value.Sum(y => y.score))
            .ThenBy(x => x.Value.Count) //?
            .ToDictionary(x => x.Key, y => y.Value);

        int place = 1;

        foreach (var team_teammates in teams)
        {
            string teamName = team_teammates.Key;
            List<Worm> teammates = team_teammates.Value;

            Console.WriteLine($"{place}. Team: {teamName} - {teams[teamName].Sum(x => x.score)}");
            place++;

            teammates = teammates
                .OrderByDescending(x => x.score)
                .ToList();

            for (int i = 0; i < teammates.Count; i++)
            {
                Console.WriteLine($"###{teammates[i].name} : {teammates[i].score}");
            }
        }
    }

    public static bool CheckIsTheNameRegistered(Dictionary<string, List<Worm>> teams, string wormName)
    {
        bool nameIsRegistered = false;

        foreach (var kvp in teams)
        {
            List<Worm> teammates = kvp.Value.ToList();

            for (int i = 0; i < teammates.Count; i++)
            {
                if (teammates[i].name == wormName)
                {
                    nameIsRegistered = true;
                }
            }
        }

        return nameIsRegistered;

    }
}

