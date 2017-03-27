using System;

class CalculateTriangleArea
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double ha = double.Parse(Console.ReadLine());
        double area = CalculateAreaOfTriangle(a, ha);
        Console.WriteLine(area);
    }

    static double CalculateAreaOfTriangle(double width, double height)
    {
        double areaOfTriangle = width * height * 1 / 2;
        return areaOfTriangle;
    }
}

