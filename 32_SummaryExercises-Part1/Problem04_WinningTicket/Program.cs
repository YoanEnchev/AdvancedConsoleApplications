using System;
using System.Collections.Generic;
using System.Linq;

class WinningTicket
{
    static void Main()
    {
        List<string> tickets = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.None)
            .Select(x => x.Trim())
            .ToList();

        for (int i = 0; i < tickets.Count; i++)
        {
            string ticket = tickets[i];

            int index_a = 0; // winning symbols
            int index_hashtag = 0;
            int index_S = 0;
            int index_v = 0;

            if (ticket.Length == 20)
            {
                string firstHalf = GetFirstHalf(ticket);
                string secondHalf = GetSecondHalf(ticket);

                for (int s = 6; s <= 10; s++)
                {
                    if (firstHalf.Contains(new string('@', s)) && secondHalf.Contains(new string('@', s)))
                    {
                        index_a = s;
                    }

                    else if (firstHalf.Contains(new string('#', s)) && secondHalf.Contains(new string('#', s)))
                    {
                        index_hashtag = s;
                    }

                    else if (firstHalf.Contains(new string('$', s)) && secondHalf.Contains(new string('$', s)))
                    {
                        index_S = s;
                    }

                    else if (firstHalf.Contains(new string('^', s)) && secondHalf.Contains(new string('^', s)))
                    {
                        index_v = s;
                    }
                }

                Console.Write($"ticket \"{ticket}\" - ");

                if (index_a > 0)
                {
                    Console.Write(index_a + "@");
                }

                else if (index_hashtag > 0)
                {
                    Console.Write(index_hashtag + "#");
                }

                else if (index_S > 0)
                {
                    Console.Write(index_S + "$");
                }

                else if (index_v > 0)
                {
                    Console.Write(index_v + "^");
                }

                if (index_a == 10 || index_hashtag == 10 || index_S == 10 || index_v == 10)
                {
                    Console.Write(" Jackpot!");
                }

                List<int> indexes = new List<int> { index_a, index_S, index_v, index_hashtag };
                
                if (indexes.Max() == 0)
                {
                    Console.Write("no match");
                }

                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("invalid ticket");
            }
        }
    }

    public static string GetSecondHalf(string ticket)
    {
        string seconfHalf = "";

        for (int i = 10; i < 20; i++)
        {
            seconfHalf += ticket[i];
        }

        return seconfHalf;
    }

    public static string GetFirstHalf(string ticket)
    {
        string firstHalf = "";

        for (int i = 0; i < 10; i++)
        {
            firstHalf += ticket[i];
        }

        return firstHalf;
    }
}

