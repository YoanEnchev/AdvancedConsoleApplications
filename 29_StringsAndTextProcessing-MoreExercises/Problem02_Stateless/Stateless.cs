using System;
using System.Collections.Generic;
using System.Linq;

class Stateless
{
    static void Main()
    {
        string state = "";
        string fiction = "";

        while (state != "collapse")
        {
            state = Console.ReadLine();

            if (state != "collapse")
            {
                fiction = Console.ReadLine();


                while (fiction.Length != 0)
                {
                    state = state.Replace(fiction, string.Empty);
                    fiction = fiction.Remove(0, 1);

                    if (fiction.Length != 0)
                    {
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                    }
                }

                if (state != "")
                {
                    Console.WriteLine(state.Trim());
                }

                else
                {
                    Console.WriteLine("(void)");
                }
            }
        }
    }
}

