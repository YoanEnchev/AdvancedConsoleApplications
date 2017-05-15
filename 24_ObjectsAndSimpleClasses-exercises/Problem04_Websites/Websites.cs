using System;
using System.Collections.Generic;
using System.Linq;

class Websites
{
    static void Main()
    {
        string input = Console.ReadLine();
        var websites = new List<Website>();

        while (input != "end")
        {
            string[] host_domain_queries = input
                .Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> queries = host_domain_queries
                .Skip(2)
                .Take(25) // all
                .ToList();

            var websiteInformatin = new Website
            {
                host = host_domain_queries[0],
                domain = host_domain_queries[1],
                queries = queries
            };

            websites.Add(websiteInformatin);
            input = Console.ReadLine();
        }

        for (int i = 0; i < websites.Count; i++)
        {
            websites[i].printData();
        }
    }
}

