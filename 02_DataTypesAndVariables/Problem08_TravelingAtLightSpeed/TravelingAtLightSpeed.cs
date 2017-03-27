using System;

class TravelingAtLightSpeed
{
    static void Main()
    {
        //52,1785714286
        decimal lightYears = decimal.Parse(Console.ReadLine());
        decimal LightWeeks = (decimal)(52.0833333333) * lightYears;

        decimal leftover = LightWeeks - (int)LightWeeks;

        decimal LightDays = 7 * leftover;

        decimal leftover2 = LightDays - (int)LightDays;
        decimal LightHours = leftover * 24;

        decimal Leftover3 = LightHours - (int)LightHours;
        decimal LightMinutes = 60 * Leftover3;

        decimal leftOver4 = LightMinutes - (int)LightMinutes;
        decimal LightSeconds = 60 * leftOver4;

        Console.WriteLine("{0} weeks", (int)LightWeeks);
        Console.WriteLine("{0} days", (int)LightDays);
        Console.WriteLine("{0} hours", (int)LightHours);
        Console.WriteLine("{0} minutes", (int)LightMinutes);
        Console.WriteLine("{0} seconds", (int)LightSeconds);

    }
}

