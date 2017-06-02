using System;
using System.Linq;
//score: 100/100

class Wormhole
{
    static void Main()
    {
        int[] wormholes = Console.ReadLine()
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToArray();

        int moves = 0;

        for (int i = 0; i < wormholes.Length; i++)
        {
            if(wormholes[i] != 0)
            {
                int goToIndex = wormholes[i];
                wormholes[i] = 0;
                i = goToIndex;
            }

            moves++;
        }

        Console.WriteLine(moves);
    }
}

