using System;
using System.Collections.Generic;
using System.Linq;

class Boxes
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = "";

        while (input != "end")
        {
            string[] coordinates = input
                .Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

            string upperLeft = coordinates[0];
            Point up_left = ReadCoordinates(upperLeft);

            string upperRight = coordinates[1];
            Point up_right = ReadCoordinates(upperRight);

            string downLeft = coordinates[2];
            Point down_left = ReadCoordinates(downLeft);

            string downRight = coordinates[3];
            Point down_right = ReadCoordinates(downRight);

            Box currentRectangle = new Box
            {
                up_left_angle = up_left,
                up_right_angle = up_right,
                down_left_angle = down_left,
                down_right_angle = down_right
            };

            result += currentRectangle.Data();
            input = Console.ReadLine();
        }
        Console.WriteLine(result);
    }

    public static Point ReadCoordinates(string coordinates)
    {
        string[] coordinatesOfPoint = coordinates.Split(':');

        Point coordinatesOfAngle = new Point
        {
            X = int.Parse(coordinatesOfPoint[0]),
            Y = int.Parse(coordinatesOfPoint[1]),
        };

        return coordinatesOfAngle;
    }
}

