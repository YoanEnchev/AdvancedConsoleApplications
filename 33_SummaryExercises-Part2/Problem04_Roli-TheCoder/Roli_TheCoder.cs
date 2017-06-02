using System;
using System.Collections.Generic;
using System.Linq;

class Roli_TheCoder
{
    static void Main()
    {
        string input = Console.ReadLine();
        var eventsInfo = new List<Event>();

        while (input != "Time for Code")
        {
            bool isEventValid = true;
            bool areParticipantsValid = true;
            bool isIDValid = true;

            string[] tokens = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int ID = int.Parse(tokens[0]);
            string eventt = tokens[1];

            if (eventt[0] != '#')
            {
                isEventValid = false;
            }

            string[] participants = tokens
                .Skip(2)
                .Take(100)
                .ToArray();

            areParticipantsValid = CheckIfParticipantsAreValid(participants);

            isIDValid = CheckIsIDValid(eventsInfo, ID, eventt);

            if (isEventValid && areParticipantsValid && isIDValid)
            {
                bool isEventAlreadyRegistered = CheckIsEventRegistered(eventsInfo, ID, eventt);

                if (isEventAlreadyRegistered)
                {
                    eventsInfo = AddNewParticipants(participants, eventt, eventsInfo);
                }

                else
                {
                    Event currentEvent = new Event
                    {
                        name = eventt,
                        ID = ID,
                        participants = participants.Distinct().ToList()
                    };

                    eventsInfo.Add(currentEvent);
                }
            }
            input = Console.ReadLine();
        }

        SortAndPrintResult(eventsInfo);
    }

    public static void SortAndPrintResult(List<Event> eventsInfo)
    {
        eventsInfo = eventsInfo.OrderByDescending(x => x.numberOfParticipants)
            .ToList();

        for (int i = 0; i < eventsInfo.Count; i++)
        {
            string eventName = eventsInfo[i].name;
            eventName = eventName.Remove(0, 1);

            Console.WriteLine($"{eventName} - {eventsInfo[i].numberOfParticipants}");
            List<string> participants = eventsInfo[i].participants
                .OrderBy(name => name)
                .ToList();

            for (int p = 0; p < participants.Count; p++)
            {
                Console.WriteLine(participants[p]);
            }
        }
    }

    public static List<Event> AddNewParticipants(string[] participants, string eventt, List<Event> eventsInfo)
    {
        var participants_list = participants.ToList();

        for (int i = 0; i < eventsInfo.Count; i++)
        {
            if (eventsInfo[i].name == eventt)
            {
                eventsInfo[i].participants = eventsInfo[i].participants
                    .Concat(participants_list)
                    .ToList()
                    .Distinct()
                    .ToList();
            }
        }

        return eventsInfo;
    }

    public static bool CheckIsEventRegistered(List<Event> eventsInfo, int iD, string eventt)
    {
        bool isAlreadyRegistered = false;

        for (int i = 0; i < eventsInfo.Count; i++)
        {
            if (eventsInfo[i].name == eventt)
            {
                isAlreadyRegistered = true;
            }
        }
        return isAlreadyRegistered;
    }

    public static bool CheckIsIDValid(List<Event> eventsInfo, int iD, string eventt)
    {
        bool isValid = true;

        for (int i = 0; i < eventsInfo.Count; i++)
        {
            if (eventsInfo[i].ID == iD && eventsInfo[i].name != eventt)
            {
                isValid = false;
            }
        }

        return isValid;
    }

    public static bool CheckIfParticipantsAreValid(string[] participants)
    {
        bool isValid = true;

        for (int i = 0; i < participants.Length; i++)
        {
            if (participants[i][0] != '@')
            {
                isValid = false;
            }
        }

        return isValid;
    }
}
