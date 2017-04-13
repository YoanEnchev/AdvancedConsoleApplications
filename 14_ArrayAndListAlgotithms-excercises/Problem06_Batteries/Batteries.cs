using System;
using System.Collections.Generic;
using System.Linq;

class Batteries
{
    static void Main()
    {
        string sequenceOfCapacities = Console.ReadLine();
        string sequenceOfUsagePerHout = Console.ReadLine();
        int hours = int.Parse(Console.ReadLine());

        List<string> capacity_asString = sequenceOfCapacities.Split(' ').ToList();
        List<string> usagePerHour_asString = sequenceOfUsagePerHout.Split(' ').ToList();

        List<double> capacity = ConvertFromStringToDouble_capacity(capacity_asString);
        List<double> usagePerHour = ConvertFromStringToDouble_usage(usagePerHour_asString);

        List<string> result = new List<string>();

        for (int i = 0; i < capacity.Count; i++)
        {
            result.Add(DataThatWillBePrinted(capacity[i], usagePerHour[i], hours, i));
        }

        PrintResult(result);
    }

    public static void PrintResult(List<string> result)
    {
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

    public static string DataThatWillBePrinted(double capacity, double usagePerHour, int hours, int i)
    {
        string result = "";

        if (hours * usagePerHour < capacity)
        {
            double howMuchCapacityLefts = capacity - hours * usagePerHour;
            result += $"Battery {i + 1}: {howMuchCapacityLefts:F2} mAh ";
            double percentage = ((howMuchCapacityLefts) / capacity) * 100;
            result += $"({percentage:F2})%";
        }

        else
        {
            double howMuchHoursLasted = (capacity / usagePerHour) + 1;
            result += $"Battery {i + 1}: dead (lasted {(int)howMuchHoursLasted} hours)";
        }

        return result;
    }

    public static List<double> ConvertFromStringToDouble_usage(List<string> usagePerHour_asString)
    {
        List<double> usagePerHour = new List<double>();

        for (int i = 0; i < usagePerHour_asString.Count; i++)
        {
            usagePerHour.Add(double.Parse(usagePerHour_asString[i]));
        }

        return usagePerHour;
    }

    public static List<double> ConvertFromStringToDouble_capacity(List<string> capacity_asString)
    {
        List<double> capacity = new List<double>();


        for (int i = 0; i < capacity_asString.Count; i++)
        {
            capacity.Add(double.Parse(capacity_asString[i]));
        }

        return capacity;
    }
}


