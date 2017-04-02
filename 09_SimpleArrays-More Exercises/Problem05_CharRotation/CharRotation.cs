using System;

class CharRotation
{
    static void Main()
    {
        string symbolsAndLetters = Console.ReadLine();
        string numbers = Console.ReadLine();

        string[] values = numbers.Split(' '); ;
        string result = "";

        for (int i = 0; i < values.Length; i++)
        {
            char symbol = symbolsAndLetters[i];
            if (int.Parse(values[i]) % 2 == 0)
            {
                int ASCII = symbol - int.Parse(values[i]);
                result += (char)ASCII;
            }
            else
            {
                int ASCII = int.Parse(values[i]) + symbol;
                result += (char)ASCII;
            }
        }
        Console.WriteLine(result);
    }
}

