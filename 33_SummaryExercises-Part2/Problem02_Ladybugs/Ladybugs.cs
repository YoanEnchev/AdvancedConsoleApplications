using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Ladybugs
{
    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        List<int> ladybugIndexes = Console.ReadLine()
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToList();

        int[] ladybugsPositions = FillWithZeroesAndOnes(fieldSize, ladybugIndexes);
        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] tokens = command.Split(' ');
            int bugAtIndex = int.Parse(tokens[0].Trim());
            string direction = tokens[1].Trim();
            int move = int.Parse(tokens[2].Trim());

            if (direction == "left")
            {
                move = -move;
            }

            if (bugAtIndex < ladybugsPositions.Length && bugAtIndex > -1)
            {
                if (ladybugsPositions[bugAtIndex] == 1)
                {
                    int moveToIndex = bugAtIndex + move;

                    if (moveToIndex > -1 && moveToIndex < ladybugsPositions.Length)
                    {
                        while (ladybugsPositions[moveToIndex] == 1)
                        {
                            moveToIndex += move;

                            if (moveToIndex < 0 || moveToIndex >= ladybugsPositions.Length)
                            {
                                break; //out
                            }
                        }
                    }

                    if (moveToIndex > -1 && moveToIndex < ladybugsPositions.Length)
                    {
                        ladybugsPositions[bugAtIndex] = 0;
                        ladybugsPositions[moveToIndex] = 1;
                    }

                    else
                    {
                        ladybugsPositions[bugAtIndex] = 0;
                    }
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", ladybugsPositions));
    }

    public static int[] FillWithZeroesAndOnes(int fieldSize, List<int> ladybugIndexes)
    {
        int[] ladybugsPositions = new int[fieldSize];

        ladybugIndexes = ladybugIndexes
            .Where(x => (x > -1 && x < 1001))
            .Take(100)
            .ToList();

        for (int i = 0; i < fieldSize; i++)
        {
            if (ladybugIndexes.Contains(i))
            {
                ladybugsPositions[i] = 1;
            }
        }
        return ladybugsPositions;
    }
}
