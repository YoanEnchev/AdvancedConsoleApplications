using System;
using System.Collections.Generic;
using System.Linq;

public class EnduranceRally
{
    public static void Main()
    {
        List<Driver> driversInfo = new List<Driver>();

        List<string> names = Console.ReadLine()
            .Split(' ')
            .Select(x => x.Trim())
            .ToList();

        List<double> zones = Console.ReadLine()
            .Split(' ')
            .Select(x => double.Parse(x))
            .ToList();

        List<int> indexOfCheckpoints = Console.ReadLine()
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToList();

        for (int i = 0; i < names.Count; i++)
        {
            double fuel = names[i][0];
            bool finishedOrNoFuel = false;

            for (int p = 0; p < zones.Count && !finishedOrNoFuel; p++)
            {            
                if (indexOfCheckpoints.Contains(p))
                {
                    fuel += zones[p];
                }

                else
                {
                    fuel -= zones[p];
                }

                if(fuel <= 0 || p == zones.Count - 1)
                {
                    Driver currentDriver = new Driver
                    {
                        fuelLeft = fuel,
                        passedZones = p + 1,
                        name = names[i]
                    };
                    driversInfo.Add(currentDriver);

                    finishedOrNoFuel = true;
                }
            }
        }

        int zonesCount = zones.Count;
        PrintResult(driversInfo, zonesCount);
    }

    public static void PrintResult(List<Driver> driversInfo,int zonesCount)
    {
        for (int i = 0; i < driversInfo.Count; i++)
        {
            Driver currentDriver = driversInfo[i];

            if(currentDriver.passedZones == zonesCount && currentDriver.fuelLeft > 0)
            {
                Console.WriteLine($"{currentDriver.name} - fuel left {currentDriver.fuelLeft:F2}");
            }

            else
            {
                Console.WriteLine($"{currentDriver.name} - reached {currentDriver.passedZones - 1}");
            }
        }
    }
}

