using System;

class CircleArea_12DigitsPrecision
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        Console.WriteLine("{0:F12}", area);
    }
}

