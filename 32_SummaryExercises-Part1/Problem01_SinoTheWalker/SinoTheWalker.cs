using System;
using System.Globalization;

public class SinoTheWalker
{
    public static void Main()
    {
        string format = @"hh\:mm\:ss";   
        var leavingTime = TimeSpan.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

        int steps = int.Parse(Console.ReadLine());
        int secondsPerStep = int.Parse(Console.ReadLine());

        var secondsInADay = 60 * 60 * 24;
        int totalSecondsNeeded = (int)(((double)steps * secondsPerStep) % secondsInADay);

        var arrivalTime = leavingTime.Add(new TimeSpan(0, 0, totalSecondsNeeded));
        Console.WriteLine("Time Arrival: " + arrivalTime.ToString(format));
    }
}

