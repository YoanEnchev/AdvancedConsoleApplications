using System;
using System.Collections.Generic;
using System.Linq;

class Messages
{
    static void Main()
    {
        List<Message> allMessagesData = new List<Message>();
        List<string> registeredNames = new List<string>();

        string input = Console.ReadLine();

        while (input != "exit")
        {
            string[] inputTokens = input.Split(' ');

            if (inputTokens[0] == "register")
            {
                registeredNames.Add(inputTokens[1]);
            }

            else
            {
                string sender = inputTokens[0];
                string reciever = inputTokens[2];
                string content = inputTokens[3];

                bool senderAndRecieverRegistered = CheckIfTheyAreRegistered(sender, reciever, registeredNames);

                if (senderAndRecieverRegistered)
                {

                    Message currentMessage = new Message
                    {
                        Sender = sender,
                        Reciever = reciever,
                        Content = content
                    };

                    allMessagesData.Add(currentMessage);
                }
            }
            input = Console.ReadLine();
        }

        string[] names = Console.ReadLine().Split(' ');
        PrintNeededMessages(allMessagesData, names);
    }

    public static void PrintNeededMessages(List<Message> allMessagesData, string[] names)
    {
        string first = names[0];
        string second = names[1];

        List<Message> messages_firstSender_secondReciever = allMessagesData
            .Where(x => x.Sender == first)
            .Where(y => y.Reciever == second)
            .ToList();

        List<Message> messages_firstReciever_secondSender = allMessagesData
          .Where(x => x.Reciever == first)
          .Where(y => y.Sender == second)
          .ToList();

        for (int i = 0; i < 100; i++)
        {
            if (i < messages_firstSender_secondReciever.Count)
            {
                messages_firstSender_secondReciever[i].PrintOtherPersonMessage();
            }

            if (i < messages_firstReciever_secondSender.Count)
            {
                messages_firstReciever_secondSender[i].PrintYourMessage();
            }
        }
    }

    public static bool CheckIfTheyAreRegistered(string sender, string reciever, List<string> registeredNames)
    {
        bool recieverRegistered = false;
        bool senderRegistered = false;

        for (int i = 0; i < registeredNames.Count; i++)
        {
            if (registeredNames[i] == reciever)
            {
                recieverRegistered = true;
            }

            if (registeredNames[i] == sender)
            {
                senderRegistered = true;
            }
        }

        bool theyAreBothRegistered = recieverRegistered && senderRegistered;
        return theyAreBothRegistered;
    }
}

