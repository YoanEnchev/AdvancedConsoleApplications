using System;
using System.Collections.Generic;
using System.Linq;

class Dict_Ref_Advanced
{
    static void Main()
    {
        string input = Console.ReadLine();

        var data = new Dictionary<string, List<int>>();
        while (input != "end")
        {
            string[] nameAndGrades = input.Split(' ', '-', '>', ','); //[1][2][3] = ""
            string name = nameAndGrades[0];

            List<int> grades = new List<int>();

            if (!data.ContainsKey(name))
            {
                data[name] = new List<int>();
            }

            grades = AddGradesIfParsable(nameAndGrades, grades);

            if (grades.Count == 0) // no grades entered    
            {
                bool isItAnEnteredName = CheckIfItIsAnEnteredName(data, nameAndGrades);

                if (isItAnEnteredName == true)
                {
                    data[name] = new List<int>(); // delete all grades till now
                    grades = data[nameAndGrades[4]]; //position of name
                }
            }

            if (grades.Count != 0)
            {
                for (int i = 0; i < grades.Count; i++)
                {
                    data[name].Add(grades[i]);
                }
            }

            input = Console.ReadLine();
        }

        PrintResult(data);
    }

    public static void PrintResult(Dictionary<string, List<int>> data)
    {
        foreach (var kvp in data)
        {
            if (kvp.Value.Count != 0)
            {
                Console.Write(kvp.Key + " === ");
                Console.WriteLine(string.Join(", ", kvp.Value));
            }
        }
    }

    public static bool CheckIfItIsAnEnteredName(Dictionary<string, List<int>> data, string[] nameAndGrades)
    {
        bool isItEnteredName = false;

        for (int i = 1; i < nameAndGrades.Length; i++)
        {
            if (data.ContainsKey(nameAndGrades[i]))
            {
                isItEnteredName = true;
            }
        }

        return isItEnteredName;
    }

    public static List<int> AddGradesIfParsable(string[] nameAndGrades, List<int> grades)
    {
        for (int i = 1; i < nameAndGrades.Length; i++)
        {
            int ignoreIt; //for tryParse

            if (int.TryParse(nameAndGrades[i], out ignoreIt))
            {
                grades.Add(int.Parse(nameAndGrades[i]));
            }
        }

        return grades;
    }
}

