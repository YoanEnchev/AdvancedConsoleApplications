using System;

class Placeholders
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string result = "";

        while(input != "end")
        {
            int index = input.IndexOf("->");

            string placeholderWords = input.Substring(index + 2);
            string words = input.Replace(placeholderWords, string.Empty);
            words = words.Replace("->", string.Empty);

            string[] putInPlaceholders = placeholderWords
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < putInPlaceholders.Length; i++)
            {
                words = words.Replace("{" + i + "}", putInPlaceholders[i]);
            }

            result += words + Environment.NewLine;
            input = Console.ReadLine();
        }

        Console.WriteLine(result);
    }
}

