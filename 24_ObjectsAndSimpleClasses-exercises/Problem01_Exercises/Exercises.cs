using System;
using System.Collections.Generic;
using System.Linq;

public class Exercises
{
    public static void Main()
    {
        string topic_courseName_judgeLink_problems = Console.ReadLine();
        var allExercises = new List<Exercise>();
       

        while (topic_courseName_judgeLink_problems != "go go go")
        {
            Exercise exerciseInfo = new Exercise();
            exerciseInfo = ReadInput(topic_courseName_judgeLink_problems);
            allExercises.Add(exerciseInfo);

            topic_courseName_judgeLink_problems = Console.ReadLine();
        }

        for (int i = 0; i < allExercises.Count; i++)
        {
            allExercises[i].PrintData();
        }
    }
  
    public static Exercise ReadInput(string topic_courseName_judgeLink_problems)
    {
        string[] tokensOfInput = topic_courseName_judgeLink_problems.Split(new[] { ' ', '-', '>', ',' },
        StringSplitOptions.RemoveEmptyEntries);

        Exercise exerciseInfo = new Exercise
        {
            Topic = tokensOfInput[0],

            CourseName = tokensOfInput[1],

            JudgeContestLink = tokensOfInput[2],

            Problems = tokensOfInput
            .Skip(3)
            .Take(tokensOfInput.Length)
            .ToList()
        };

        return exerciseInfo;
    }
}

