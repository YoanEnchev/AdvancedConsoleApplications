using System;

public class Cat
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int IQ { get; set; }

    public void Talk()
    {
        Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
    }

    public void PrintCatsData()
    {
        Console.WriteLine($"Cat: {Name}, Age: {Age}, IQ: {IQ}");
    }
}

