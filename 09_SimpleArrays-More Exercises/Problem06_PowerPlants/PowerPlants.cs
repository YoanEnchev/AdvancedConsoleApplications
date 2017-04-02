using System;

class PowerPlants
{
    static void Main()
    { // days yes seasons no
        string numbers = Console.ReadLine();
        string[] powerOfFlower = numbers.Split(' ');

        int currentPower;
        int passedDays = 0;
        int seasons = 0;

        int bloomPeriod = powerOfFlower.Length ;
        int daysForBloomPeriod = 0;

        int flowerThatLivedLongestDays = 0;
        int flowerThatLivedLongestSeasons = 0;
        int multiply = 0;

        for (int i = 0; i < powerOfFlower.Length; i++)
        {
            currentPower = int.Parse(powerOfFlower[i]);
            while (currentPower > 0)
            {
                if (passedDays == i + powerOfFlower.Length * multiply)                 
                {
                    currentPower++;
                    multiply++;
                }

                if (daysForBloomPeriod == bloomPeriod)
                {
                    seasons++;
                    currentPower++;
                    daysForBloomPeriod = 0;
                }
                passedDays++;
                daysForBloomPeriod++;
                currentPower--;

                if (flowerThatLivedLongestDays < passedDays)
                {
                    flowerThatLivedLongestDays = passedDays;
                }

                if(flowerThatLivedLongestSeasons < seasons)
                {
                    flowerThatLivedLongestSeasons = seasons;
                }
            }
            daysForBloomPeriod = 0;
            passedDays = 0;
            multiply = 0;
            seasons = 0;
        }
        PrintResult(flowerThatLivedLongestDays, flowerThatLivedLongestSeasons);
    }

    public static void PrintResult(int flowerThatLivedLongestDays, int flowerThatLivedLongestSeasons)
    {
        string addIfNeeded = "";

        if (flowerThatLivedLongestDays != 1)
        {
            addIfNeeded = "s";
        }
        Console.WriteLine($"survived {flowerThatLivedLongestDays} days ({flowerThatLivedLongestSeasons} season{addIfNeeded})");
    }
}

