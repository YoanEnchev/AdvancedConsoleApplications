using System;

class HelloName
{
    static void Main()
    {
        RecieveAndPrintName();
    }

    static void RecieveAndPrintName()
    {
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}

