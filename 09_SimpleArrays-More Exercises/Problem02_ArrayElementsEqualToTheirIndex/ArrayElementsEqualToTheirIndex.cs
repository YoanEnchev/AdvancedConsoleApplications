using System;

class ArrayElementsEqualToTheirIndex
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] values = numbers.Split(' ');

        string result = "";

        for (int i = 0; i < values.Length; i++)
        {
            if (i == int.Parse(values[i]))
            {
                result += values[i] + " ";
            }
        }
        Console.WriteLine(result);
    }
}

