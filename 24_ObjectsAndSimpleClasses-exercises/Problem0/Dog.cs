using System;

public class Dog
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int NumberOfLegs { get; set; }

    public void Talk()
    {
        Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
    }

    public void PrintDogsData()
    {
        Console.WriteLine($"Dog: {Name}, Age: {Age}, Number Of Legs: {NumberOfLegs}");
    }

}

