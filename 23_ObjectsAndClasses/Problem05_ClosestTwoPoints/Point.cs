using System;

class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public void PrintCoordinates()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}

