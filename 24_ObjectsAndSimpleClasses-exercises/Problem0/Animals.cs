using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
      //  Console.OutputEncoding = System.Text.Encoding.UTF8;
        string input = Console.ReadLine();

        var dogs = new List<Dog>();
        var cats = new List<Cat>();
        var snakes = new List<Snake>();

        while (input != "I'm your Huckleberry")
        {
            string[] tokens = input.Split(' ');
            string commandOrClass = tokens[0];

            if (commandOrClass == "talk")
            {
                string name = tokens[1];

                bool isItADog = CheckIsItADogsName(name, dogs);
                bool isItACat = CheckIsItACatsName(name, cats);
                bool isItSnake = CheckIsItASnakesName(name, snakes);

                Talk(isItADog, isItACat, isItSnake);
            }

            if (commandOrClass == "Dog")
            {
                Dog Data_dog = new Dog
                {
                    Name = tokens[1],
                    Age = int.Parse(tokens[2]),
                    NumberOfLegs = int.Parse(tokens[3])
                };

                dogs.Add(Data_dog);
            }

            if (commandOrClass == "Cat")
            {
                Cat Data_cat = new Cat
                {
                    Name = tokens[1],
                    Age = int.Parse(tokens[2]),
                    IQ = int.Parse(tokens[3])
                };

                cats.Add(Data_cat);
            }

            if (commandOrClass == "Snake")
            {
                Snake Data_Snake = new Snake
                {
                    Name = tokens[1],
                    Age = int.Parse(tokens[2]),
                    Cruelty = int.Parse(tokens[3])
                };

                snakes.Add(Data_Snake);
            }

            input = Console.ReadLine();
        }

        PrintAnimalsData(dogs, cats, snakes);
    }

    public static void PrintAnimalsData(List<Dog> dogs, List<Cat> cats, List<Snake> snakes)
    {
        for (int i = 0; i < dogs.Count; i++)
        {
            dogs[i].PrintDogsData();
        }

        for (int i = 0; i < cats.Count; i++)
        {
            cats[i].PrintCatsData();
        }

        for (int i = 0; i < snakes.Count; i++)
        {
            snakes[i].PrintSnakesData();
        }
    }

    public static void Talk(bool isItADog, bool isItACat, bool isItSnake)
    {
        if(isItADog == true)
        {
            Dog talkingDog = new Dog { };
            talkingDog.Talk();
        }

        if (isItACat == true) //else if
        {
            Cat talkingCat = new Cat { };
            talkingCat.Talk();
        }

        if (isItSnake == true)
        {
            Snake talkingSnake = new Snake { };
            talkingSnake.Talk();
        }
    }

    public static bool CheckIsItASnakesName(string name, List<Snake> snakes)
    {
        bool isItASnakesName = false;

        for (int i = 0; i < snakes.Count; i++)
        {
            if (snakes[i].Name == name)
            {
                isItASnakesName = true;
            }
        }

        return isItASnakesName;
    }

    public static bool CheckIsItACatsName(string name, List<Cat> cats)
    {
        bool isItACatsName = false;

        for (int i = 0; i < cats.Count; i++)
        {
            if (cats[i].Name == name)
            {
                isItACatsName = true;
            }
        }

        return isItACatsName;
    }

    public static bool CheckIsItADogsName(string name, List<Dog> dogs)
    {
        bool isItADogsName = false;

        for (int i = 0; i < dogs.Count; i++)
        {
            if(dogs[i].Name == name)
            {
                isItADogsName = true;
            }
        }

        return isItADogsName;
    }
}

