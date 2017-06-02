using System;
using System.Collections.Generic;
using System.Linq;

class CommandInterpreter
{
    static void Main()
    {
        List<string> elements = Console.ReadLine()
            .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToList();

        string command = Console.ReadLine();

        while (command != "end")
        {
            bool inputIsValid = CheckIsInputValid(command, elements);

            if (inputIsValid)
            {
                string[] tokens = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string operation = tokens[0];

                if (operation == "reverse")
                {
                    elements = ReverseCertainPart(elements, tokens);
                }

                if (operation == "sort")
                {
                    elements = SortCertainPart(elements, tokens);
                }

                if (operation == "rollLeft")
                {
                    elements = RollLeft(elements, tokens);
                }

                if (operation == "rollRight")
                {
                    elements = RollRight(elements, tokens);
                }
            }

            else
            {
                Console.WriteLine("Invalid input parameters.");
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"[{string.Join(", ", elements)}]");
    }

    public static List<string> RollRight(List<string> elements, string[] tokens)
    {
        int rollTimes = int.Parse(tokens[1]);
        rollTimes = rollTimes % elements.Count;

        string[] rolledToRight = new string[elements.Count];

        for (int i = 0; i < rollTimes; i++)
        {
            string lastElement_beforeRoll = elements[elements.Count - 1];
            rolledToRight[0] = lastElement_beforeRoll;

            for (int j = 1; j < elements.Count; j++)
            {
                rolledToRight[j] = elements[j - 1];
            }

            elements = rolledToRight.ToList();
        }

        elements = rolledToRight.ToList();

        return elements;
    }

    public static List<string> RollLeft(List<string> elements, string[] tokens)
    {
        int rollTimes = int.Parse(tokens[1]);
        rollTimes = rollTimes % elements.Count;

        for (int i = 0; i < rollTimes; i++)
        {
            string firstElement_beforeRoll = elements[0];

            for (int j = 0; j < elements.Count - 1; j++)
            {
                string elementNow = elements[j];
                string elementAfter = elements[j + 1];

                elements[j] = elementAfter;
            }

            elements[elements.Count - 1] = firstElement_beforeRoll;
        }

        return elements;
    }

    public static List<string> SortCertainPart(List<string> elements, string[] tokens)
    {
        int startingIndex = int.Parse(tokens[2]);
        int count = int.Parse(tokens[4]);

        elements.Sort(startingIndex, count, StringComparer.InvariantCulture);

        return elements;
    }

    public static List<string> ReverseCertainPart(List<string> elements, string[] tokens)
    {
        int startingIndex = int.Parse(tokens[2]);
        int count = int.Parse(tokens[4]);

        elements.Reverse(startingIndex, count);
        return elements;
    }

    public static bool CheckIsInputValid(string command, List<string> elements)
    {
        bool inputIsValid = true;

        string[] tokens = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (tokens[0] == "reverse" || tokens[0] == "sort")
        {
            int startingIndex = int.Parse(tokens[2]);
            int count = int.Parse(tokens[4]);

            if (startingIndex < 0 || startingIndex >= elements.Count)
            {
                inputIsValid = false;
            }

            if (count < 0 || count > elements.Count)
            {
                inputIsValid = false;
            }

            if(startingIndex + count > elements.Count)
            {
                inputIsValid = false;
            }
        }

        return inputIsValid;
    }
}

