using System;
//score: 100/100

class WormTest
{
    static void Main()
    {
        double length_meters = double.Parse(Console.ReadLine());
        double width_cm = double.Parse(Console.ReadLine());
        double length_cm = length_meters * (double)(100);

        double remainer = length_cm % width_cm;

        if(remainer == 0 || width_cm == 0 ) //cannot be calculated
        {
            double result = width_cm * length_cm;
            Console.WriteLine($"{result:F2}");
        }

       else if(remainer != 0)
        {
            double percent = length_cm / width_cm * 100;
            Console.WriteLine($"{percent:F2}%");
        }
    }
}

