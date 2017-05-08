using System;
using System.Collections.Generic;
using System.Linq;

class DistanceBetweenPoints
{
    static void Main()
    {
        string[] x1_y1 = Console.ReadLine().Split(' ');
        string[] x2_y2 = Console.ReadLine().Split(' ');

        double distanceBetween_X1andX2 = 0;
        double distanceBetween_Y1andY2 = 0;

        double x1 = double.Parse(x1_y1[0]);
        double y1 = double.Parse(x1_y1[1]);
        double x2 = double.Parse(x2_y2[0]);
        double y2 = double.Parse(x2_y2[1]);

        var Point_1 = new Point
        {
            X = x1,
            Y = y1
        };

        var Point_2 = new Point
        {
            X = x2,
            Y = y2
        };

        distanceBetween_Y1andY2 = Math.Abs(Point_1.Y - Point_2.Y);
        distanceBetween_X1andX2 = Math.Abs(Point_1.X - Point_2.X);
        double distance = Math.Sqrt(Math.Pow(distanceBetween_X1andX2, 2)
        + Math.Pow(distanceBetween_Y1andY2, 2));
        Console.WriteLine($"{distance:F3}");
    }
}

