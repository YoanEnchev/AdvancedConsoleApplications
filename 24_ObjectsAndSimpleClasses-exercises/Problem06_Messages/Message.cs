using System;
using System.Collections.Generic;
using System.Linq;

class Message
{
    public string Content { get; set; }

    public string Sender { get; set; }

    public string Reciever { get; set; }

    public void PrintOtherPersonMessage()
    {
        Console.WriteLine($"{Sender}: {Content}");
    }

    public void PrintYourMessage()
    {
        Console.WriteLine($"{Content} :{Sender}");
    }
}

