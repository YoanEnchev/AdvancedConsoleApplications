using System;
using System.Collections.Generic;

class JSONStringify
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> dataForEveryStudent = new List<string>();

        while (input != "stringify")
        {
            int indexForName = input.IndexOf(":");
            string name = input.Substring(0, indexForName - 1);

            string ageAndGrades = input.Replace(name + " : ", string.Empty);
            int indexForAge = ageAndGrades.IndexOf(" ");
            int age = int.Parse(ageAndGrades.Substring(0, indexForAge));

            string grades = ageAndGrades.Replace(age + " -> ", string.Empty);

            string data = "{name:\"" + name + "\",age:" + age + ",grades:[" + grades + "]}";
            dataForEveryStudent.Add(data);

            input = Console.ReadLine();
        }

        Console.WriteLine("[" + string.Join(",", dataForEveryStudent) + "]");
    }
}

