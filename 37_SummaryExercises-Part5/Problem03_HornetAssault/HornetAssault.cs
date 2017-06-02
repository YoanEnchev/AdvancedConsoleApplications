using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class HornetAssault
{
    static void Main()
    {
        List<long> beehives = Console.ReadLine()
        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => long.Parse(x))
        .ToList();

        List<long> hornets = Console.ReadLine()
        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => long.Parse(x))
        .ToList();

        for (int i = 0; i < beehives.Count; i++)
        {   
            if(hornets.Count == 0)
            {
                break;
            }

            long hornestSum = hornets.Sum();

            if (hornestSum > beehives[i])
            {
                beehives[i] = 0;
            }

            else
            {
                beehives[i] -= hornestSum;
                hornets.RemoveAt(0);
            }
        }

        beehives = beehives
             .Where(x => (x != 0))
             .Take(10000)//all
             .ToList();

        if(beehives.Count != 0)
        {
            Console.WriteLine(string.Join(" ", beehives));
        }

        else
        {          
            Console.WriteLine(string.Join(" ", hornets));
        }
    }
}

