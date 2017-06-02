using System;

class CharityMarathon
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int runners = int.Parse(Console.ReadLine());
        double averageLaps = double.Parse(Console.ReadLine());

        int lenghtOfTrack_meters = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine()) * days;
        decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());
             
        if(runners > capacity)
        {
            runners = capacity;
        } 

        double runnedDistance_meters = runners * averageLaps * lenghtOfTrack_meters;
        double runnedKilometers = runnedDistance_meters / 1000;
        decimal raisedMoney = (decimal)runnedKilometers * moneyPerKilometer;

        Console.WriteLine($"Money raised: {raisedMoney:F2}");
    }
}

