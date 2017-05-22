using System;
using System.Collections.Generic;
using System.Linq;

public class JSON_parse
{
   public static void Main()
    {
        string input = Console.ReadLine();
        input = input.Remove(0, 2);
        input = input.Remove(input.Length - 3, 2);

        List<Student> studentsData = new List<Student>();
        List<string> data_forEachStudent_JSON = input
            .Split(new[] { "},{" }, StringSplitOptions.None)
            .ToList();

        for (int i = 0; i < data_forEachStudent_JSON.Count; i++)
        {
            int name_index = data_forEachStudent_JSON[i].LastIndexOf("\"");
            string name = data_forEachStudent_JSON[i].Substring(0, name_index);
            name = name.Remove(0, 6);

            string ageAndGrades = data_forEachStudent_JSON[i]
                .Replace("name:\"" + name + "\",age:",string.Empty);
            int age_index = ageAndGrades.IndexOf(",");
            int age = int.Parse(ageAndGrades.Substring(0, age_index));

            string grades = ageAndGrades.Replace(age.ToString(), string.Empty);
            grades = grades.Remove(0, 9);
            grades = grades.Remove(grades.Length - 1);

            if(grades == "" || grades == string.Empty)
            {
                grades = "None";
            }

            Student currentStudent = new Student
            {
                name = name,
                age = age,
                grades = grades               
            };

            studentsData.Add(currentStudent);
        }

        PrintResult(studentsData);
    }

    public static void PrintResult(List<Student> studentsData)
    {
        for (int i = 0; i < studentsData.Count; i++)
        {
            Student student = studentsData[i];
            Console.WriteLine($"{student.name} : {student.age} -> {student.grades}");
        }
    }
}

