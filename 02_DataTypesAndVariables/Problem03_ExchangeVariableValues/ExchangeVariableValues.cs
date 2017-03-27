using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine()); ;
        int c = b;
        b = a;
        a = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

