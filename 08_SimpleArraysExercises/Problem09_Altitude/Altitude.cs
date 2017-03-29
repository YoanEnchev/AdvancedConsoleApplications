using System;

class Altitude
{
    static void Main()
    {
        string valuesAndComands = Console.ReadLine();
        string[] elements = valuesAndComands.Split(' ');
        double altitude = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            if (i == 0)
            {
                altitude += double.Parse(elements[i]);
            }

            if (elements[i] == "up")
            {
                i++;
                altitude += double.Parse(elements[i]);
            }

            if (elements[i] == "down")
            {
                i++;
                altitude -= double.Parse(elements[i]);
            }
        }

        if (altitude > 0)
        {
            Console.WriteLine($"got through safely. current altitude: {altitude}m");
        }

        else
        {
            Console.WriteLine("crashed");
        }
    }
}

