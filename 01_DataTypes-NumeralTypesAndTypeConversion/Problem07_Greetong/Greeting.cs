using System;

class Greeting
{
    static void Main()
    {
        String FirstName = Console.ReadLine();
        String Surname = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Hello, {0} {1}. You are {2} years old.",
            FirstName, Surname, age);
    }
}

