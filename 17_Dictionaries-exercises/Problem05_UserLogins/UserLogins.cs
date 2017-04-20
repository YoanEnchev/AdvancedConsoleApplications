using System;
using System.Collections.Generic;
using System.Linq;

class UserLogins
{
    static void Main(string[] args)
    {
        string[] nameAndPassword = Console.ReadLine().Split(' ');
        string username = "";
        string password = "";
        int unsuccessfulAttempts = 0;

        Dictionary<string, string> usernameAndPassWord = new Dictionary<string, string>();

        while (!nameAndPassword.Contains("login"))
        {
            username = nameAndPassword[0];
            password = nameAndPassword[2]; //[1] = "->"
            usernameAndPassWord[username] = password;
            nameAndPassword = Console.ReadLine().Split(' ');
        }

        nameAndPassword = Console.ReadLine().Split(' '); // login

        while (!nameAndPassword.Contains("end"))
        {
            username = nameAndPassword[0];
            password = nameAndPassword[2]; //[1] = "->"

            if (usernameAndPassWord.ContainsKey(username))
            {
                if (password == usernameAndPassWord[username])
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }

                else
                {
                    Console.WriteLine($"{username}: login failed");
                    unsuccessfulAttempts++;
                }
            }

            else
            {
                Console.WriteLine($"{username}: login failed");
                unsuccessfulAttempts++;
            }
            nameAndPassword = Console.ReadLine().Split(' ');
        }

        PrintTheCountOfUnsuccessfulAttempts(unsuccessfulAttempts);
    }

    public static void PrintTheCountOfUnsuccessfulAttempts(int unsuccessfulAttempts)
    {
        Console.WriteLine($"unsuccessful login attempts: {unsuccessfulAttempts}");
    }
}

