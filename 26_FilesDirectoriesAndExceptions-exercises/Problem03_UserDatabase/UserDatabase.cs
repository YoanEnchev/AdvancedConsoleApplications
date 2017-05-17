using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class UserDatabase
{
    public static void Main()
    {
        string input = Console.ReadLine();
        List<User> allUsersData = ReadFileInformation();

        while (input != "exit")
        {
            string[] inputTokens = input.Split(' ');
            string command = inputTokens[0];

            if (command == "register")
            {
                string name = inputTokens[1];
                string password = inputTokens[2];
                string confirmPassword = inputTokens[3];

                if (password != confirmPassword)
                {
                    Console.WriteLine("The two passwords must match.");
                }

                else
                {
                    bool isNameTaken = CheckIsNameTaken(name, allUsersData);

                    if (isNameTaken)
                    {
                        Console.WriteLine("The given username already exists.");
                    }

                    else
                    {
                        User currentUser = new User
                        {
                            name = name,
                            password = password,
                            loggedIn = false
                        };

                        allUsersData.Add(currentUser);
                    }
                }
            }

            if (command == "login")
            {
                string name = inputTokens[1];
                string password = inputTokens[2];

                bool isThereUserWithThatName = CheckIsNameTaken(name, allUsersData);

                if (isThereUserWithThatName == false)
                {
                    Console.WriteLine("There is no user with the given username.");
                }

                else
                {
                    User infoAboutUser = GetUserInfo(name, allUsersData);

                    if (password != infoAboutUser.password)
                    {
                        Console.WriteLine("The password you entered is incorrect.");
                    }

                    else
                    {
                        bool isThereLoggedUser = CheckIfUserIsLogged(allUsersData);

                        if (isThereLoggedUser == true)
                        {
                            Console.WriteLine("There is already a logged in user");
                        }

                        else
                        {
                            infoAboutUser.loggedIn = true;
                            allUsersData = ChangeLoginStatusAboutUser(allUsersData, infoAboutUser);
                        }
                    }
                }
            }

            if (command == "logout")
            {
                bool isUserLoggedIn = CheckIfUserIsLogged(allUsersData);

                if (isUserLoggedIn)
                {
                    allUsersData = logOutUser(allUsersData);
                }

                else
                {
                    Console.WriteLine("There is no currently logged in user.");
                }
            }

            input = Console.ReadLine();
        }

        GetUserInformationInFile(allUsersData);
    }

    public static List<User> ReadFileInformation()
    {
        List<string> FileData_Lines = File.ReadAllLines("userData.txt")
            .ToList();

        List<User> usersData = new List<User>();

        for (int i = 0; i < FileData_Lines.Count; i++)
        {
            List<string> name_password_isLoggedIn = FileData_Lines[i]
                 .Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string name = name_password_isLoggedIn[0];
            string pasword = name_password_isLoggedIn[1];
            bool isLoggedIn = bool.Parse(name_password_isLoggedIn[2]);

            User currentUser = new User
            {
                name = name,
                password = pasword,
                loggedIn = isLoggedIn
            };

            usersData.Add(currentUser);
        }
        return usersData;
    }

    public static void GetUserInformationInFile(List<User> allUsersData)
    {
        string result = "";
        for (int i = 0; i < allUsersData.Count; i++)
        {
            string name = allUsersData[i].name;
            string password = allUsersData[i].password;
            bool loggenIn = allUsersData[i].loggedIn;

            string currentUser = $"{name} - {password} - {loggenIn}" + Environment.NewLine;
            result += currentUser;          
        }
        File.WriteAllText("userData.txt", result);
    }

    public static List<User> logOutUser(List<User> allUsersData)
    {
        for (int i = 0; i < allUsersData.Count; i++)
        {
            if (allUsersData[i].loggedIn == true)
            {
                allUsersData[i].loggedIn = false;
            }
        }

        return allUsersData;
    }

    public static List<User> ChangeLoginStatusAboutUser(List<User> allUsersData, User infoAboutUser)
    {
        for (int i = 0; i < allUsersData.Count; i++)
        {
            if (allUsersData[i].name == infoAboutUser.name)
            {
                allUsersData[i].loggedIn = true;
            }
        }

        return allUsersData;
    }

    public static bool CheckIfUserIsLogged(List<User> allUsersData)
    {
        bool isUserLogged = false;

        for (int i = 0; i < allUsersData.Count; i++)
        {
            if (allUsersData[i].loggedIn == true)
            {
                isUserLogged = true;
            }
        }

        return isUserLogged;
    }

    public static User GetUserInfo(string name, List<User> allUsersData)
    {
        User userInfo = new User { };

        for (int i = 0; i < allUsersData.Count; i++)
        {
            if (name == allUsersData[i].name)
            {
                userInfo = allUsersData[i];
            }
        }

        return userInfo;
    }

    public static bool CheckIsNameTaken(string name, List<User> allUsersData)
    {
        bool nameIsTaken = false;

        for (int i = 0; i < allUsersData.Count; i++)
        {
            if (name == allUsersData[i].name)
            {
                nameIsTaken = true;
            }
        }

        return nameIsTaken;
    }
}

