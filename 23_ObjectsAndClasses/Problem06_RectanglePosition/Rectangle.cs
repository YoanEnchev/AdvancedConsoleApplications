using System;
using System.Collections.Generic;
using System.Linq;

class Rectangle
{
    public double left { get; set; }

    public double top { get; set; }

    public double width { get; set; }

    public double height { get; set; }

    public double bottom
    {
        get
        {
            return top + height;
        }
    }

    public double right
    {
        get
        {
            return left + width;
        }
    }


    public bool isItInside(Rectangle rectangle_2)
    {
        var isLeftValid = rectangle_2.left <= left;
        var isTopValid = rectangle_2.top <= top;
        var isRightValid = rectangle_2.right >= right;
        var isBottomValid = rectangle_2.bottom >= bottom;

        if (isLeftValid && isTopValid && isRightValid && isBottomValid)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}

