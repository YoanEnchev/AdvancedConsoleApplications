using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Commits
{
    static void Main()
    {
        var allCommitsData = new List<Commit>();

        string patternForValidURL = @"https:\/\/github.com\/([A-Z]|[a-z]|[0-9]|-)*\/(-|[A-Z]|[a-z]|_)*\/commit\/[a-z|A-Z|0-9]{40},.*,\d+,\d+";
        string input = "";
        string newLine = "";

        while (newLine != "git push")
        {
            newLine = Console.ReadLine();
            input += newLine + Environment.NewLine; // || adres + "something"
        }

        MatchCollection valids = Regex.Matches(input, patternForValidURL);

        for (int i = 0; i < valids.Count; i++)
        {
            Commit currentCommit = GetDataAboutCommits(valids[i]);
            allCommitsData.Add(currentCommit);
        }

        allCommitsData = allCommitsData
            .OrderBy(x => x.user)
            .ThenBy(x => x.repository)
            .ToList();

        PrintResult(allCommitsData);
    }

    public static void PrintResult(List<Commit> allCommitsData)
    {
        HashSet<string> names = new HashSet<string>(); 

        for (int i = 0; i < allCommitsData.Count; i++)
        {
            names.Add(allCommitsData[i].user);
        }

        List<string> names_list = names.ToList();

        for (int i = 0; i < names_list.Count; i++)
        {
            Console.WriteLine(names_list[i] + ":");
            List<Commit> commitsOfCurrentUser = new List<Commit>();

            for (int s = 0; s < allCommitsData.Count; s++)
            {
                if(names_list[i] == allCommitsData[s].user)
                {
                    commitsOfCurrentUser.Add(allCommitsData[s]);
                }
            }

            HashSet<string> repositoriesOfUser = new HashSet<string>();

            for (int p = 0; p < commitsOfCurrentUser.Count; p++)
            {
                repositoriesOfUser.Add(commitsOfCurrentUser[p].repository);
            }

            List<string> repositoriesOfUser_list = repositoriesOfUser.ToList();

            for (int n = 0; n < repositoriesOfUser_list.Count; n++)
            {
                Console.WriteLine("  " + repositoriesOfUser_list[n] + ":");
                int totalAdditionsCount = 0;
                int totalDeletionsCount = 0;

                for (int q = 0; q < commitsOfCurrentUser.Count; q++)
                {
                    if (commitsOfCurrentUser[q].repository == repositoriesOfUser_list[n])
                    {
                        Console.Write($"    commit {commitsOfCurrentUser[q].hash}: {commitsOfCurrentUser[q].message} ");
                        Console.WriteLine($"({commitsOfCurrentUser[q].additions} additions, {commitsOfCurrentUser[q].deletions} deletions)");

                        totalAdditionsCount += commitsOfCurrentUser[q].additions;
                        totalDeletionsCount += commitsOfCurrentUser[q].deletions;
                    }
                }

                Console.WriteLine($"    Total: {totalAdditionsCount} additions, {totalDeletionsCount} deletions");
            }
        }     
    }

    public static Commit GetDataAboutCommits(Match match)
    {
        string URL = match.ToString();
        string[] tokens = URL.Split(new[] { '/', ',' }, StringSplitOptions.RemoveEmptyEntries);

        string username = tokens[2];
        string repository = tokens[3];
        string hash = tokens[5];
        string message = tokens[6]; //message has / or ,

        int beforeLastElement = tokens.Length - 2;
        int lastElement = tokens.Length - 1;

        int additions = int.Parse(tokens[beforeLastElement]);
        int deletions = int.Parse(tokens[lastElement]);

        Commit currentCommit = new Commit
        {
            user = username,
            repository = repository,
            hash = hash,
            message = message,
            additions = additions,
            deletions = deletions
        };

        return currentCommit;
    }
}

