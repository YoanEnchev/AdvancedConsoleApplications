using System.Collections.Generic;

public class Event
{
    public string name { get; set; }

    public List<string> participants { get; set; }

    public int numberOfParticipants
    {
        get
        {
            return participants.Count;
        }
    }

    public int ID { get; set; }
}

