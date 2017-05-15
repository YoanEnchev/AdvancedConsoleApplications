using System;
using System.Collections.Generic;
using System.Linq;

public class Exercise
{
    public string Topic { get; set; }

    public string CourseName { get; set; }

    public string JudgeContestLink { get; set; }

    public List<string> Problems { get; set; }

    public void PrintData()
    {        
            Console.WriteLine($"Exercises: {Topic}");
            Console.WriteLine($"Problems for exercises and homework for the \"{CourseName}\" course @ SoftUni.");
            Console.WriteLine($"Check your solutions here: {JudgeContestLink}");

            for (int i = 0; i < Problems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Problems[i]}");
            }
        }
    }


