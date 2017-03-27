using System;

class FloatOrInteger
{
    static void Main()
    {
        double number = Double.Parse(Console.ReadLine());
        if (number == (int)number)
        {
            Console.WriteLine((int)number);
        }
        else
        {
            Console.WriteLine(Math.Round(number));
        }
    }
}

