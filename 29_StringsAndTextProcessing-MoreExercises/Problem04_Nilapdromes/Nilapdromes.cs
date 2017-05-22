using System;

class Nilapdromes
{
    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            string checkForNilapdromes = "";
            string border = "";
            string core = "";

            for (int i = 0; i <= (input.Length / 2) - 1; i++)
            {
                checkForNilapdromes += input[i];

                if (input.LastIndexOf(checkForNilapdromes) + checkForNilapdromes.Length == input.Length)
                {
                    border = checkForNilapdromes;
                    core = input.Remove(0, border.Length); // remove left border
                    core = core.Remove(core.Length - border.Length, border.Length);//remove right border;                 
                }
            }

            if (border != "" && core != "" && core != string.Empty)
            {
                Console.WriteLine(core + border + core);
            }

            input = Console.ReadLine();
        }
    }
}

