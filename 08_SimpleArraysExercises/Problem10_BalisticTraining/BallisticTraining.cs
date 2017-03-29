using System;

class BallisticTraining
{
    static void Main()
    {
        string InputPlaneCoordinates = Console.ReadLine();
        string InputDirections = Console.ReadLine();

        string[] planeCoordinates = InputPlaneCoordinates.Split(' ');
        string[] directions = InputDirections.Split(' ');

        int planeCoordinateByX = int.Parse(planeCoordinates[0]);
        int planeCoordinateByY = int.Parse(planeCoordinates[1]);

        int x = 0;
        int y = 0;

        for (int i = 0; i < directions.Length; i++)
        {
            if (directions[i] == "up")
            {
                i++;
                y += int.Parse(directions[i]);
            }

            if (directions[i] == "down")
            {
                i++;
                y -= int.Parse(directions[i]);
            }

            if (directions[i] == "right")
            {
                i++;
                x += int.Parse(directions[i]);
            }

            if (directions[i] == "left")
            {
                i++;
                x -= int.Parse(directions[i]);
            }
        }

        Console.WriteLine($"firing at [{x}, {y}]");

        if (x == planeCoordinateByX && y == planeCoordinateByY)
        {
            Console.WriteLine("got 'em!");
        }
        else
        {
            Console.WriteLine("better luck next time...");
        }
    }
}

