using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

public class RegisteredUsers
{
    public static void Main()
    {
        string input = Console.ReadLine();
        var nameAndDateInDictionary = new Dictionary<string, DateTime>();

        while (input != "end")
        {
            List<string> NameAndDate = input
            .Split(' ') //! like Yoan Enchev -> 27.04.2017
            .ToList();

            string name = NameAndDate[0];
            string Getdate = NameAndDate[2]; //[1] ->

            var date = DateTime.ParseExact(Getdate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            nameAndDateInDictionary[name] = date;

            input = Console.ReadLine();
        }

        int howManyEqualPairs = 0;

        foreach (var kvp_1 in nameAndDateInDictionary)
        {
            DateTime date_1 = kvp_1.Value;
            string name_1 = kvp_1.Key;

            foreach (var kvp_2 in nameAndDateInDictionary)
            {
                DateTime date_2 = kvp_2.Value;
                string name_2 = kvp_2.Key;

                if (date_1 == date_2 && name_1 != name_2)
                {
                    howManyEqualPairs++;
                }
            }
        }

        Dictionary<string, DateTime> DescendingDate;
     
            DescendingDate = nameAndDateInDictionary
                 .Reverse()   
                .OrderByDescending(d => d.Value)
                .ToDictionary(x => x.Key, y => y.Value);

        var takeFiveOrLess = DescendingDate
           .Skip(DescendingDate.Count - 5)
           .Take(5)
           .ToDictionary(x => x.Key, y => y.Value);

        Console.WriteLine(string.Join(Environment.NewLine, takeFiveOrLess.Keys));
    }
}

