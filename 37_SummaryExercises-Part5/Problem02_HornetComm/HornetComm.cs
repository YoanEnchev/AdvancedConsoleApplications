using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class HornetComm
{
    static void Main()
    {
        var privateMessages = new List<string>();
        var broadcastMessages = new List<string>();

        string input = Console.ReadLine();

        string pattern_private = @"^(\d)* <-> ([0-9A-Za-z]+)$";
        string pattern_broadcast = @"^([^\d])+ <-> ([0-9A-Za-z]+)$";

        while (input != "Hornet is Green")
        {
            bool isPrivateMessage = Regex.IsMatch(input, pattern_private);
            bool isBroadcast = Regex.IsMatch(input, pattern_broadcast);

            if (isPrivateMessage)
            {
                string[] tokens = input
                    .Split(new[] { " <-> " }, StringSplitOptions.None);

                string recipient = tokens[0];
                recipient = ReverseString(recipient);

                string message = tokens[1];
                string privateMessage = $"{recipient} -> {message}";

                privateMessages.Add(privateMessage);
            }

            if (isBroadcast)
            {
                string[] tokens = input
                    .Split(new[] { " <-> " }, StringSplitOptions.None);

                string message = tokens[0];
                string frequancy = tokens[1];

                frequancy = MakeCapitalLettersSmallAndSmallCapitals(frequancy);
                string broadcastMessage = $"{frequancy} -> {message}";
                broadcastMessages.Add(broadcastMessage);
            }

            input = Console.ReadLine();
        }

        PrintResult(privateMessages, broadcastMessages);
    }

    public static string ReverseString(string recipient)
    {
        string reversed = "";

        for (int i = recipient.Length - 1; i > -1; i--)
        {
            reversed += recipient[i];
        }

        return reversed;
    }

    public static void PrintResult(List<string> privateMessages, List<string> broadcastMessages)
    {
        Console.WriteLine("Broadcasts:");
        bool noBroadcastsWerePrinted = true;

        for (int i = 0; i < broadcastMessages.Count; i++)
        {
            Console.WriteLine(broadcastMessages[i]);
            noBroadcastsWerePrinted = false;
        }

        if (noBroadcastsWerePrinted)
        {
            Console.WriteLine("None");
        }


        Console.WriteLine("Messages:");
        bool noMessagesWerePrinted = true;

        for (int i = 0; i < privateMessages.Count; i++)
        {
            Console.WriteLine(privateMessages[i]);
            noMessagesWerePrinted = false;
        }

        if (noMessagesWerePrinted)
        {
            Console.WriteLine("None");
        }
    }


    public static string MakeCapitalLettersSmallAndSmallCapitals(string frequancy)
    {
        string converted = "";

        for (int i = 0; i < frequancy.Length; i++)
        {
            string currentSymbol = frequancy[i].ToString();

            if (currentSymbol == currentSymbol.ToUpper())
            {
                converted += currentSymbol.ToLower();
            }

            else if (currentSymbol == currentSymbol.ToLower())
            {
                converted += currentSymbol.ToUpper();
            }
        }

        return converted;
    }
}

