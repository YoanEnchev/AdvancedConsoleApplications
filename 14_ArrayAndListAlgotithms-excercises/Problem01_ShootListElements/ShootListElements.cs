using System;
using System.Collections.Generic;
using System.Linq;

class ShootListElements
{
    static void Main()
    {
        string command = "";
        int lastShootedElement = -1;
        double averageOfList = 0;

        List<int> numbers = new List<int>();

        while (command != "stop")
        {
            command = Console.ReadLine();

            if (command != "bang" && command != "stop")
            {
                numbers.Insert(0, int.Parse(command));
            }

            if (numbers.Count != 0)
            {
                averageOfList = CalculateAverage(numbers);
            }

            if (command == "bang")
            {
                bool endNow = true;
                if (numbers.Count != 0)
                {
                    endNow = false;
                    List<int> shootedElementAndNumbers = new List<int>();
                    shootedElementAndNumbers = EliminateNumberThatisBelowAverageAndPrint(numbers, averageOfList);
                    lastShootedElement = shootedElementAndNumbers[0];

                    if (shootedElementAndNumbers.Count != 0) //!
                    {
                        numbers.Clear();

                        for (int i = 1; i < shootedElementAndNumbers.Count; i++)
                        {
                            numbers.Add(shootedElementAndNumbers[i]);
                        }
                    }

                    numbers = DecrementEveryElementByOne(numbers);
                }

                if (numbers.Count == 0 && endNow == true)
                {
                    Console.WriteLine($"nobody left to shoot! last one was {lastShootedElement}");
                }
            }

            if (command == "stop")
            {
                if (numbers.Count != 0)
                {
                    PrintSurvivors(numbers);
                }

                if (numbers.Count == 0)
                {
                    PrintThatAllAreShootedAndThelastShooted(numbers, lastShootedElement);
                }
            }
        }
    }

    public static void PrintThatAllAreShootedAndThelastShooted(List<int> numbers, int lastShootedElement)
    {
        Console.WriteLine($"you shot them all. last one was {lastShootedElement}");
    }

    public static void PrintSurvivors(List<int> numbers)
    {
        Console.Write("survivors: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }

    public static List<int> DecrementEveryElementByOne(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i]--;
        }

        return numbers;
    }

    public static List<int> EliminateNumberThatisBelowAverageAndPrint(List<int> numbers, double averageOfList)
    {
        bool isNumberRemoved = false;
        int whichElementWasShooted = -1;

        for (int i = 0; i < numbers.Count && isNumberRemoved == false; i++)
        {
            if (numbers.Count == 1)
            {
                whichElementWasShooted = numbers[i];
                numbers.RemoveAt(i); //!
                isNumberRemoved = true;
            }

            else if (numbers[i] < averageOfList)
            {
                whichElementWasShooted = numbers[i];
                numbers.RemoveAt(i);
                isNumberRemoved = true;
            }
        }

        List<int> shootedElementAndNumbers = new List<int>();
        shootedElementAndNumbers.Add(whichElementWasShooted);

        for (int i = 0; i < numbers.Count; i++)
        {
            shootedElementAndNumbers.Add(numbers[i]);
        }

        Console.WriteLine($"shot {whichElementWasShooted}");

        return shootedElementAndNumbers;
    }

    public static double CalculateAverage(List<int> numbers)
    {
        double average = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            average += numbers[i];
        }

        average = average / numbers.Count;
        return average;
    }
}

