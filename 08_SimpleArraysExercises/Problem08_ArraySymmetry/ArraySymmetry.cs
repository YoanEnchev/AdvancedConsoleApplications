using System;

class ArraySymmetry
{
    static void Main()
    {
        string values = Console.ReadLine();
        string[] elements = values.Split(' ');
        string isItSymmetric = "Yes";

        for (int i = 0; i < elements.Length - 2; i++)
        {
            if (elements[0 + i] != elements[elements.Length - i - 1])
            {
                isItSymmetric = "No";
            }
        }
        Console.WriteLine(isItSymmetric);
    }
}

