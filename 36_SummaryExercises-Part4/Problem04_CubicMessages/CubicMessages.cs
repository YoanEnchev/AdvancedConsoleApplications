using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class CubicMessages
{
    static void Main()
    {
        string encryptedMessage = Console.ReadLine();
        int length = int.Parse(Console.ReadLine());

        string pattern_validMessage = @"^([0-9]*)([a-zA-Z]*)([^a-zA-Z]*)$";
        var decryptedMessages = new List<string>();

        while (true)
        {
            bool validMessage = Regex.IsMatch(encryptedMessage, pattern_validMessage);

            if (validMessage)
            {
                Match message = Regex.Match(encryptedMessage, pattern_validMessage);

                string decryptString = message.Groups[2].Value.ToString();
                bool validLength = decryptString.Length == length;

                if (validLength)
                {
                    string digits_string = message.Groups[1].Value.ToString();
                    List<int> digits = digits_string
                        .ToCharArray()
                        .Select(x => int.Parse(x.ToString()))
                        .ToList();

                    string partThatMaycontainDigits = message.Groups[3].Value.ToString();

                    digits = AddDigitsFromLastPart(partThatMaycontainDigits, digits);
                    string verificationCode = GetVertificationCode(digits, decryptString);
                    string decrypted = decryptString + " == " + verificationCode;

                    decryptedMessages.Add(decrypted);
                }
            }

            encryptedMessage = Console.ReadLine();

            if (encryptedMessage == "Over!")
            {
                break;
            }

            length = int.Parse(Console.ReadLine());
        }

        PrintResult(decryptedMessages);
    }

    public static void PrintResult(List<string> decryptedMessages)
    {
        for (int i = 0; i < decryptedMessages.Count; i++)
        {
            Console.WriteLine(decryptedMessages[i]);
        }
    }

    public static string GetVertificationCode(List<int> digits, string decryptString)
    {
        string vertificationCode = "";

        for (int i = 0; i < digits.Count; i++)
        {
            if (digits[i] < decryptString.Length && digits[i] > -1)
            {
                vertificationCode += decryptString[digits[i]].ToString();
            }

            else
            {
                vertificationCode += " ";
            }
        }

        return vertificationCode;
    }

    public static List<int> AddDigitsFromLastPart(string partThatMaycontainDigits, List<int> digits)
    {
        for (int i = 0; i < partThatMaycontainDigits.Length; i++)
        {
            char mayBeDigit = partThatMaycontainDigits[i];

            if (mayBeDigit >= 48 && mayBeDigit <= 57)
            {
                digits.Add(int.Parse(mayBeDigit.ToString()));
            }
        }

        return digits;
    }
}