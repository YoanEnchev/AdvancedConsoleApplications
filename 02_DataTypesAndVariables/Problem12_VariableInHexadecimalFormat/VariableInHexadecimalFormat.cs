using System;

class VariableInHexadecimalFormat
{
    static void Main()
    {
        string number = Console.ReadLine();
        int result = Convert.ToInt32(number, 16);
        Console.WriteLine(result);
    }
}

