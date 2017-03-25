using System;

class Centureis
{
    static void Main()
    {
        Console.Write("Centuries = ");
        byte centuries = Byte.Parse(Console.ReadLine());
        int years = 100 * centuries;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        int minutes = hours * 60;

        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes.",
            centuries, years, days, hours, minutes);
    }
}

