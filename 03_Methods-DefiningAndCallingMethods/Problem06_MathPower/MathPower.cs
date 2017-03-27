using System;

class MathPower
{
    static void Main()
    {
        double number = Double.Parse(Console.ReadLine());
        double pow = Double.Parse(Console.ReadLine());
        Console.WriteLine(PowNumber(number, pow));
    }

    static double PowNumber(double number, double pow)
    {
        double result = Math.Pow(number, pow);
        return result;
    }
}

