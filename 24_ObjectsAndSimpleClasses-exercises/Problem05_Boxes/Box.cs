using System;
using System.Collections.Generic;
using System.Linq;

class Box
{
    public Point up_right_angle { get; set; }

    public Point up_left_angle { get; set; }

    public Point down_right_angle { get; set; }

    public Point down_left_angle { get; set; }

    public int width
    {
        get
        {
            return Math.Abs(up_left_angle.X - up_right_angle.X);
        }
    }

    public int height
    {
        get
        {
            return Math.Abs(up_left_angle.Y - down_left_angle.Y);
        }
    }

    public int Perimeter
    {
        get
        {
            return 2 * (height + width);
        }
    }

    public int Area
    {
        get
        {
            return (height * width);
        }
    }

    public string Data()
    {
        string data = $"Box: {width}, {height}" + Environment.NewLine;
        data += $"Perimeter: {Perimeter}" + Environment.NewLine;
        data += $"Area: {Area}" + Environment.NewLine;

        return data;
    }
}

