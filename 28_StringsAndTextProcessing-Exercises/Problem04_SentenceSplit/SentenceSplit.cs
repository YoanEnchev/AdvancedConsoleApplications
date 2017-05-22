using System;

class SentenceSplit
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string delimiter = Console.ReadLine();

        string[] elements = input
            .Split(new[] { delimiter }, StringSplitOptions.None);

        Console.Write("[" + string.Join(", ",elements) + "]");
    }
}

