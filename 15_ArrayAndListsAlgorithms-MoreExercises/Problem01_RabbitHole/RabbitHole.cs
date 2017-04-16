using System;
using System.Collections.Generic;
using System.Linq;

class RabbitHole
{
    static void Main()
    {
        string obstaclesAndRabitHole = Console.ReadLine();
        List<string> elements = obstaclesAndRabitHole.Split(' ').ToList();

        int energy = int.Parse(Console.ReadLine());
        int position = 0;
        int[] positionAndEnergy = new int[2];

        bool killedByBomd = false;
        bool end = false;

        while (energy > 0 && end == false)
        {
            if (elements[position].Contains("Right"))
            {
                positionAndEnergy = Right(elements, position, energy);
                position = positionAndEnergy[0];
                energy = positionAndEnergy[1];
            }

            else if (elements[position].Contains("Left"))
            {
                positionAndEnergy = Left(elements, position, energy);
                position = positionAndEnergy[0];
                energy = positionAndEnergy[1];
            }

            else if (elements[position].Contains("Bomb"))
            {
                elements.RemoveAt(position);
                energy = energy - GetIndexAfterBomb(elements[position]);
                position = 0;
                killedByBomd = true;
                end = true;
            }

            else if (elements[position] == "RabbitHole")
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
                end = true;
            }

            if (elements[elements.Count - 1] != "RabbitHole")
            {
                elements.RemoveAt(elements.Count - 1);
            }

            elements.Add("Bomb|" + energy);

            if (energy <= 0 && killedByBomd == false)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
                end = true;
            }

            if (killedByBomd == true)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
                end = true;
            }
        }
    }

    public static int GetIndexAfterBomb(string element)
    {
        string index_asString = "";

        for (int i = 5; i < element.Length; i++)
        {
            index_asString += element[i];
        }

        int index = int.Parse(index_asString);
        return index;
    }

    public static int[] Left(List<string> elements, int position, int energy)
    {
        string jumpToLeft_asString = "";

        for (int i = 5; i < elements[position].Length; i++)
        {
            jumpToLeft_asString += elements[position][i];
        }

        int jumpToLeft = int.Parse(jumpToLeft_asString);
        energy = energy - jumpToLeft;
        int add = 0;

        while (add < jumpToLeft)
        {
            if (position == 0)
            {
                position = elements.Count;
            }
            position -= 1;
            add++;
        }

        int[] positionAndEnergy = new int[2];
        positionAndEnergy[0] = position;
        positionAndEnergy[1] = energy;
        return positionAndEnergy;
    }

    public static int[] Right(List<string> elements, int position, int energy)
    {
        string jumpToRight_asString = "";

        for (int i = 6; i < elements[position].Length; i++)
        {
            jumpToRight_asString += elements[position][i];
        }

        int jumpToRight = int.Parse(jumpToRight_asString);
        energy = energy - jumpToRight;
        int add = 0;

        while (add < jumpToRight)
        {
            if (position == elements.Count - 1)
            {
                position = -1;
            }
            position += 1;
            add++;
        }
        int[] positionAndEnergy = new int[2];
        positionAndEnergy[0] = position;
        positionAndEnergy[1] = energy;
        return positionAndEnergy;
    }
}

