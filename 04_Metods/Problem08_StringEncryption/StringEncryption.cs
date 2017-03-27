using System;

class StringEncryption
{
    static void Main()
    {
        int HowManyTimes = int.Parse(Console.ReadLine());
        string result = "";

        for (int i = 1; i <= HowManyTimes; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            Encrypt(letter);
            result += Encrypt(letter);
        }
        Console.WriteLine(result);
    }

    static string Encrypt(char letter)
    {
        int ASCIIcode = letter;
        int FirstDigit;
        int LastDigit;


        if (ASCIIcode < 100)
        {
            FirstDigit = ASCIIcode / 10;
            LastDigit = ASCIIcode % 10;
        }
        else
        {
            FirstDigit = ASCIIcode / 100;
            LastDigit = ASCIIcode % 10;
        }

        int ASCIIcodePlusLastDigit = ASCIIcode + LastDigit;
        char firstSymbol = (char)ASCIIcodePlusLastDigit;

        int ASCIIcodeMinusFirsttDigit = ASCIIcode - FirstDigit;
        char lastSymbol = (char)ASCIIcodeMinusFirsttDigit;

        return $"{firstSymbol}{FirstDigit}{LastDigit}{lastSymbol}";
    }
}

