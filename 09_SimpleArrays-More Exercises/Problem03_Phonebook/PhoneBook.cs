using System;

class PhoneBook
{
    static void Main()
    {
        string phoneNumbers = Console.ReadLine();
        string[] phoneNumbersInArray = phoneNumbers.Split(' ');

        string names = Console.ReadLine();
        string[] phoneNumberOwner = names.Split(' ');

        string[] phoneNumberOwnerAndPhone = ConcatinateNameWithPhoneNumber(phoneNumbersInArray, phoneNumberOwner);

        string name = "";
        string result = "";

        while (name != "done")
        {
            name = Console.ReadLine();
            for (int i = 0; i < phoneNumberOwner.Length; i++)
            {
                if (name == phoneNumberOwner[i])
                {
                    result += phoneNumberOwnerAndPhone[i] + Environment.NewLine;
                }
            }
        }
        Console.WriteLine(result);
    }


    public static string[] ConcatinateNameWithPhoneNumber(string[] phoneNumbersInArray, string[] phoneNumberOwner)
    {
        string[] phoneNumberOwnerAndPhone = new string[phoneNumbersInArray.Length];

        for (int i = 0; i < phoneNumbersInArray.Length; i++)
        {
            phoneNumberOwnerAndPhone[i] = phoneNumberOwner[i] + " -> " + phoneNumbersInArray[i];
        }
        return phoneNumberOwnerAndPhone;
    }
}

