using System;
using System.Collections.Generic;
using System.Linq;

public class FilterBase
{
    static void Main(string[] args)
    {
        Dictionary<string, int> namesAndAges = new Dictionary<string, int>();
        Dictionary<string, double> namesAndSalaries = new Dictionary<string, double>();
        Dictionary<string, string> namesAndPosition = new Dictionary<string, string>();

        string[] nameAndCharacteristic = Console.ReadLine().Split(' ');

        while (nameAndCharacteristic[0] != "filter" && nameAndCharacteristic[2] != "base")
        {
            string name = nameAndCharacteristic[0];
            string characteristic = nameAndCharacteristic[2];

            int age = 0;
            bool isItAge = int.TryParse(characteristic, out age);

            if (isItAge == true)
            {
                namesAndAges[name] = age;
            }

            double salary = 0.0;
            bool isItSalary = double.TryParse(characteristic, out salary);

            if (isItSalary == true && isItAge == false)
            {
                namesAndSalaries[name] = salary;
            }

            if (isItSalary == false && isItAge == false)
            {
                namesAndPosition[name] = characteristic;
            }

            nameAndCharacteristic = Console.ReadLine().Split(' ');
        }

        string filterBy = "";

        if (nameAndCharacteristic[0] == "filter" && nameAndCharacteristic[1] == "base")
        {
            filterBy = Console.ReadLine();
        }

        PrintResult(filterBy, namesAndAges, namesAndSalaries, namesAndPosition);

    }

    public static void PrintResult(string filterBy, Dictionary<string, int> namesAndAges, Dictionary<string, double> namesAndSalaries, Dictionary<string, string> namesAndPosition)
    {
        if (filterBy == "Age")
        {
            foreach (var kvp in namesAndAges)
            {
                Console.WriteLine($"Name: {kvp.Key}");
                Console.WriteLine($"Age: {kvp.Value}");
                Console.WriteLine("====================");
            }
        }

        if (filterBy == "Salary")
        {
            foreach (var kvp in namesAndSalaries)
            {
                Console.WriteLine($"Name: {kvp.Key}");
                Console.WriteLine($"Salary: {kvp.Value:F2}");
                Console.WriteLine("====================");
            }
        }

        if (filterBy == "Position")
        {
            foreach (var kvp in namesAndPosition)
            {
                Console.WriteLine($"Name: {kvp.Key}");
                Console.WriteLine($"Position: {kvp.Value}");
                Console.WriteLine("====================");
            }
        }
    }
}

