using System;

class MelrahShake
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = Console.ReadLine();
        bool stringWasPrinted = false;

        while (pattern != "")
        {
            int firstIndex_pattern = input.IndexOf(pattern);
            int lastIndex_pattern = input.LastIndexOf(pattern);

            if (firstIndex_pattern != lastIndex_pattern)
            {
                Console.WriteLine("Shaked it.");

                input = input.Remove(firstIndex_pattern, pattern.Length);
                input = input.Remove(lastIndex_pattern - pattern.Length, pattern.Length);


                pattern = pattern.Remove(pattern.Length / 2, 1);
            }

            else
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(input);
                stringWasPrinted = true;
                break;
            }
        }

        if(!stringWasPrinted)
        {
            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }

    }
}

