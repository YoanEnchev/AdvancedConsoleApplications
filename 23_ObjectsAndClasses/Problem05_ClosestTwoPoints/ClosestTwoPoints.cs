using System;
using System.Collections.Generic;
using System.Linq;

class ClosestTwoPoints
{
    static void Main()
    {
        int howMany = int.Parse(Console.ReadLine());
        var pointsCoordinates = new List<Point>();
        for (int i = 0; i < howMany; i++)
        {
            var x_y = Console.ReadLine()
            .Split(' ')
            .Select(coordinate => double.Parse(coordinate))
            .ToArray();

            var xy = new Point
            {
                X = x_y[0],
                Y = x_y[1]
            };

            pointsCoordinates.Add(xy);
        }
        PrintClosestTwoPointsAndDistance(pointsCoordinates);
    }

    public static void PrintClosestTwoPointsAndDistance(List<Point> pointsCoordinates)
    {
        double distance_previous = double.MaxValue;
        Point point_1_Result = null;
        Point point_2_Result = null;

        for (int first = 0; first < pointsCoordinates.Count; first++)
        {
            for (int second = first + 1; second < pointsCoordinates.Count; second++)
            {
                double x_length = Math.Abs(pointsCoordinates[first].X - pointsCoordinates[second].X);
                double y_length = Math.Abs(pointsCoordinates[first].Y - pointsCoordinates[second].Y);

                double distance_current = Math.Sqrt(Math.Pow(x_length, 2) + Math.Pow(y_length, 2));

                if (distance_current < distance_previous)
                {
                    point_1_Result = pointsCoordinates[first];
                    point_2_Result = pointsCoordinates[second];

                    distance_previous = distance_current;
                }
            }
        }
        Console.WriteLine($"{distance_previous:F3}");
        point_1_Result.PrintCoordinates();
        point_2_Result.PrintCoordinates();
    }
}
