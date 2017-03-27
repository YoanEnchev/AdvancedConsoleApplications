using System;

class IntegerToBase
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int baseToConvertTo = int.Parse(Console.ReadLine());
        Console.WriteLine(ConvertNumberToBase(number, baseToConvertTo));
    }

    static string ConvertNumberToBase(int number, int baseToConvertTo)
    {
        string result = "";
        while (number > 0)
        {
            result = number % baseToConvertTo + result;
            number = number / baseToConvertTo;
        }
        return result;
    }
}

