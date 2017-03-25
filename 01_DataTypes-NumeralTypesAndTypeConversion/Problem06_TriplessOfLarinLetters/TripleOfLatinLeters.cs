using System;

class TripleOfLatinLeters
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int First = 97;
        int Second = 97;
        int Third = 97;

        while (First < 97 + n)
        {
            while (Second < 97 + n)
            {
                while (Third < 97 + n)
                {
                    Console.WriteLine((char)First + "" + (char)Second + "" + (char)Third);
                    Third++;
                }
                Second++;
                Third = 97;
            }
            First++;
            Second = 97;
        }
    }
}

