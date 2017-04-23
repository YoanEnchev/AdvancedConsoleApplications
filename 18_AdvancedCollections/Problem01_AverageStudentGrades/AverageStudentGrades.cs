using System;
using System.Collections.Generic;
using System.Linq;

class AverageStudentGrades
{
    static void Main()
    {
        int howMany = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> namesAndGrades = new Dictionary<string, List<double>>();

        for (int i = 0; i < howMany; i++)
        {
            string[] nameAndGrade = Console.ReadLine().Split(' ');
            string name = nameAndGrade[0];
            double grade = double.Parse(nameAndGrade[1]);

            namesAndGrades = AddNameAndGrade(name, grade, namesAndGrades);
        }

        PrintResult(namesAndGrades);
    }

    public static void PrintResult(Dictionary<string, List<double>> namesAndGrades)
    {
        foreach (var kvp in namesAndGrades)
        {
            Console.Write($"{kvp.Key} -> ");

            for (int i = 0; i < kvp.Value.Count; i++)
            {
                Console.Write($"{kvp.Value[i]:F2} ");
            }

            double average = kvp.Value.Average();
            Console.Write($"(avg: {average:F2})");
            Console.WriteLine();
        }
    }

    public static Dictionary<string, List<double>> AddNameAndGrade(string name, double grade, Dictionary<string, List<double>> namesAndGrades)
    {
        if (!namesAndGrades.ContainsKey(name))
        {
            namesAndGrades[name] = new List<double>();
        }

        namesAndGrades[name].Add(grade);
        return namesAndGrades;
    }
}

