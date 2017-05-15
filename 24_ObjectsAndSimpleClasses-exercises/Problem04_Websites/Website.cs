using System;
using System.Collections.Generic;

class Website
{
    public string host { get; set; }

    public string domain { get; set; }

    public List<string> queries { get; set; }

    public void printData()
    {
        Console.Write($"https://www.{host}.{domain}");

        if (queries.Count != 0)
        {
            Console.Write("/query?=");

            for (int i = 0; i < queries.Count; i++)
            {
                if (i != queries.Count - 1)
                {
                    Console.Write($"[{queries[i]}]&");
                }

                else
                {
                    Console.Write($"[{queries[i]}]");
                }
            }
        }
        Console.WriteLine();
    }
}

