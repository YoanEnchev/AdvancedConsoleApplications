using System;

    class HornetWings
    {
        static void Main(string[] args)
        {
        int wingFlaps = int.Parse(Console.ReadLine());
        double distance_meters_per1000Flaps = double.Parse(Console.ReadLine());
        int flapsWithoutBreak = int.Parse(Console.ReadLine());

        double distance = wingFlaps * distance_meters_per1000Flaps / 1000;
        int breaks = wingFlaps / flapsWithoutBreak;

        double timeInBreaks = breaks * 5;
        double timeSpentFlying = wingFlaps / 100;
        double time = timeInBreaks + timeSpentFlying;

        Console.WriteLine($"{distance:F2} m.");
        Console.WriteLine($"{time} s.");
        }
    }

