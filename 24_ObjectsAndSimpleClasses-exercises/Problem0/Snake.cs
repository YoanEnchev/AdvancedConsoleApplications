using System;

public class Snake
    {
    public string Name { get; set; }

    public int Age { get; set; }

    public int Cruelty { get; set; }

    public void Talk()
    {
        Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
    }

    public void PrintSnakesData()
    {
        Console.WriteLine($"Snake: {Name}, Age: {Age}, Cruelty: {Cruelty}");
    }
}

