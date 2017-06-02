using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class FootballStandings
{
    static void Main()
    {
        string decrypt = Regex.Escape(Console.ReadLine());
        string matchInfo = Console.ReadLine();
        string pattern = $@".*{decrypt}(.*){decrypt}.*{decrypt}(.*){decrypt}.*?((\d+):(\d+))";

        List<Team> teamsInfo = new List<Team>();

        while (matchInfo != "final")
        {
            Match currentMatch = Regex.Match(matchInfo, pattern);

            string country_1 = currentMatch.Groups[1].Value.ToString();
            string country_2 = currentMatch.Groups[2].Value.ToString();

            country_1 = ReverseAndUppercase(country_1);
            country_2 = ReverseAndUppercase(country_2);

            int goals_1 = int.Parse(currentMatch.Groups[4].Value);
            int goals_2 = int.Parse(currentMatch.Groups[5].Value);

            int points_1 = 0;
            int points_2 = 0;

            if (goals_1 > goals_2)
            {
                points_1 = 3;
            }

            else if (goals_1 == goals_2)
            {
                points_1 = 1;
                points_2 = 1;
            }

            else
            {
                points_2 = 3;
            }

            bool country_1_alreadyInList = CheckIfTheListHasTheName(country_1, teamsInfo);
            bool country_2_alreadyInList = CheckIfTheListHasTheName(country_2, teamsInfo);

            if (country_1_alreadyInList)
            {
                teamsInfo = AddPointsAndGoals(teamsInfo, country_1, goals_1, points_1);
            }

            else
            {
                Team notRegistered = new Team
                {
                    name = country_1,
                    goals = goals_1,
                    points = points_1
                };

                teamsInfo.Add(notRegistered);
            }

            if (country_2_alreadyInList)
            {
                teamsInfo = AddPointsAndGoals(teamsInfo, country_2, goals_2, points_2);
            }

            else
            {
                Team notRegistered = new Team
                {
                    name = country_2,
                    goals = goals_2,
                    points = points_2
                };

                teamsInfo.Add(notRegistered);
            }

            matchInfo = Console.ReadLine();
        }

        SortAndPrintResult(teamsInfo);
    }

    public static string ReverseAndUppercase(string country)
    {
        string reversed = "";

        for (int i = country.Length - 1; i > -1; i--)
        {
            reversed += country[i];
        }

        return reversed.ToUpper();
    }

    public static void SortAndPrintResult(List<Team> teamsInfo)
    {
        List<Team> points = teamsInfo
            .OrderByDescending(x => x.points)
            .ThenBy(x => x.name)
            .ToList();

        Console.WriteLine("League standings:");

        for (int i = 0; i < points.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {points[i].name} {points[i].points}");
        }


        List<Team> goals = teamsInfo
            .OrderByDescending(x => x.goals)
            .ThenBy(x => x.name)
            .Take(3)
            .ToList();

        Console.WriteLine("Top 3 scored goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"- {goals[i].name} -> {goals[i].goals}");
        }
    }

    public static List<Team> AddPointsAndGoals(List<Team> teamsInfo, string country, int goals, int points)
    {
        for (int i = 0; i < teamsInfo.Count; i++)
        {
            if (teamsInfo[i].name == country)
            {
                teamsInfo[i].goals += goals;
                teamsInfo[i].points += points;
            }
        }

        return teamsInfo;
    }

    public static bool CheckIfTheListHasTheName(string country, List<Team> teamsInfo)
    {
        bool isRegistered = false;

        for (int i = 0; i < teamsInfo.Count; i++)
        {
            if (country == teamsInfo[i].name)
            {
                isRegistered = true;
            }

        }

        return isRegistered;
    }
}

