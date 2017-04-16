using System;
using System.Collections.Generic;
using System.Linq;

class JapaneseRoulette
{
    static void Main()
    {
        List<string> cylinder_asString = Console.ReadLine().Split(' ').ToList();
        List<int> cylinder = ConvertFromStringToInt(cylinder_asString);

        List<string> strenghtAndDirection = Console.ReadLine().Split(' ').ToList();

        int currentPositionOfBullet = GetCurrentPositionOfBulet(cylinder);

        bool wasSomeoneShooted = false; //unlucky

        for (int i = 0; i < strenghtAndDirection.Count && wasSomeoneShooted == false; i++)
        {
            string[] strenghtAndDirection_forCurrentPlayer = strenghtAndDirection[i].Split(',');
            int strenght = int.Parse(strenghtAndDirection_forCurrentPlayer[0]);
            string direction = strenghtAndDirection_forCurrentPlayer[1];

            if (direction == "Left")
            {
                currentPositionOfBullet = MoveToLeft(strenght, currentPositionOfBullet);
            }

            else if (direction == "Right")
            {
                currentPositionOfBullet = MoveToRight(strenght, currentPositionOfBullet);
            }

            if (currentPositionOfBullet == 2)
            {
                Console.WriteLine($"Game over! Player {i} is dead.");
                wasSomeoneShooted = true;
            }

            currentPositionOfBullet++;

            if (currentPositionOfBullet == 6)
            {
                currentPositionOfBullet = 0;
            }
        }

        if (wasSomeoneShooted == false)
        {
            Console.WriteLine("Everybody got lucky!");
        }
    }

    public static int MoveToRight(int strenght, int currentPositionOfBullet)
    {
        for (int i = 0; i < strenght; i++)
        {
            if (currentPositionOfBullet == 5)
            {
                currentPositionOfBullet = -1;
            }

            currentPositionOfBullet++;
        }

        return currentPositionOfBullet;
    }

    public static int MoveToLeft(int strenght, int currentPositionOfBullet)
    {
        for (int i = 0; i < strenght; i++)
        {
            if (currentPositionOfBullet == 0)
            {
                currentPositionOfBullet = 6;
            }

            currentPositionOfBullet--;
        }

        return currentPositionOfBullet;
    }

    public static int GetCurrentPositionOfBulet(List<int> cylinder)
    {
        int position = 0;

        for (int i = 0; i < cylinder.Count; i++)
        {
            if (cylinder[i] == 1)
            {
                position = i;
            }
        }

        return position;
    }

    public static List<int> ConvertFromStringToInt(List<string> cylinder_asString)
    {
        List<int> cylinder = new List<int>();

        for (int i = 0; i < cylinder_asString.Count; i++)
        {
            cylinder.Add(int.Parse(cylinder_asString[i]));
        }

        return cylinder;
    }
}

