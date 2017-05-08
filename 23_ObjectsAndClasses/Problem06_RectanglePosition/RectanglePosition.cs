using System;
using System.Collections.Generic;
using System.Linq;

class RectanglePosition
{
    static void Main()
    {
        double[] left_top_width_height_1 = Console.ReadLine()
            .Split(' ')
            .Select(x => double.Parse(x))
            .ToArray();

        var rectangle_1 = new Rectangle
        {
            left = left_top_width_height_1[0],
            top = left_top_width_height_1[1],
            width = left_top_width_height_1[2],
            height = left_top_width_height_1[3],
        };


        double[] left_top_width_height_2 = Console.ReadLine()
           .Split(' ')
           .Select(x => double.Parse(x))
           .ToArray();

        var rectangle_2 = new Rectangle
        {
            left = left_top_width_height_2[0],
            top = left_top_width_height_2[1],
            width = left_top_width_height_2[2],
            height = left_top_width_height_2[3],
        };

        bool inside = rectangle_1.isItInside(rectangle_2);

        if (inside)
        {
            Console.WriteLine("Inside");
        }

        else
        {
            Console.WriteLine("Not inside");
        }
    }
}

