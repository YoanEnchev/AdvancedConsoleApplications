using System;
using System.Text.RegularExpressions;

namespace Problem02_MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main()
        {
            string pattern = @"\+359(-|\ )[0-9](\1)[0-9]{3}(\1)[0-9]{4}\b";
            string input = Console.ReadLine();

            MatchCollection matchingNumbers = Regex.Matches(input, pattern);

            for (int i = 0; i < matchingNumbers.Count; i++)
            {
                Console.WriteLine(matchingNumbers[i]);
            }

        }
    }
}
