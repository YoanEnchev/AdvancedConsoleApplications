using System;

class elevator
{
    static void Main()
    {
        double people = int.Parse(Console.ReadLine());
        double capacity = int.Parse(Console.ReadLine());

        double courses = people / capacity;
        if (courses == (int)courses)
        {
            Console.WriteLine((int)courses);
        }
        else
        {
            Console.WriteLine((int)courses + 1);
        }
    }
}

