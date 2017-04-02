using System;

class Phone
{
    static void Main()
    {
        string phoneNumbers = Console.ReadLine();
        string[] phoneNumbersInArray = phoneNumbers.Split(' ');

        string names = Console.ReadLine();
        string[] phoneNumberOwner = names.Split(' ');

        string commandAndNameOrNumber = Console.ReadLine();
        string[] commandAndNameOrNumberInArray = commandAndNameOrNumber.Split(' ');

        string command = commandAndNameOrNumberInArray[0];
        string nameOrNumber = commandAndNameOrNumberInArray[1];

        string result = "";

        while (command != "done")
        {
            if (command == "call")
            {
                result += Call(phoneNumbersInArray, phoneNumberOwner, nameOrNumber);
            }

            if (command == "message")
            {
                result += Message(phoneNumbersInArray, phoneNumberOwner, nameOrNumber);
            }
            commandAndNameOrNumber = Console.ReadLine();
            commandAndNameOrNumberInArray = commandAndNameOrNumber.Split(' ');

            command = commandAndNameOrNumberInArray[0];
            if (command != "done")
            {
                nameOrNumber = commandAndNameOrNumberInArray[1];
            }
        }
        Console.WriteLine(result);
    }


    public static string Message(string[] phoneNumbersInArray, string[] phoneNumberOwner, string nameOrNumber)
    {

        string name = "";
        string number = "";
        string result = "";

        int whichElement = 0;

        for (int i = 0; i < phoneNumbersInArray.Length; i++)
        {
            if (nameOrNumber == phoneNumbersInArray[i])
            {
                name = nameOrNumber; //then sending sms to  + number
                whichElement = i;
            }

            if (nameOrNumber == phoneNumberOwner[i])
            {
                number = nameOrNumber; // sending sms to  + name
                whichElement = i;
            }
        }

        if (number == "")
        {
            result += "sending sms to " + phoneNumberOwner[whichElement] + "..." + Environment.NewLine;
        }

        if (name == "")
        {
            result += "sending sms to " + phoneNumbersInArray[whichElement] + "..." + Environment.NewLine;
        }

        int sumDigitsOfPhoneNumber = 0;
        string phoneNumber = phoneNumbersInArray[whichElement];

        for (int i = 0; i < phoneNumber.Length; i++)
        {
            char digit = phoneNumber[i];

            if (digit == '0' || digit == '1' || digit == '2' || digit == '3' || digit == '4'
                || digit == '5' || digit == '6' || digit == '7' || digit == '8' || digit == '9')
            {
                int digitAsNumber = digit - 48; // because of ASCII
                sumDigitsOfPhoneNumber -= digitAsNumber;
            }
        }

        if (sumDigitsOfPhoneNumber % 2 != 0)
        {
            result += "busy" + Environment.NewLine;
        }

        else
        {
            result += "meet me there" + Environment.NewLine;
        }
        return result;
    }

    public static string Call(string[] phoneNumbersInArray, string[] phoneNumberOwner, string nameOrNumber)
    {
        string name = "";
        string number = "";
        string result = "";

        int whichElement = 0;

        for (int i = 0; i < phoneNumbersInArray.Length; i++)
        {
            if (nameOrNumber == phoneNumbersInArray[i])
            {
                name = nameOrNumber; //then calling + number
                whichElement = i;
            }

            if (nameOrNumber == phoneNumberOwner[i])
            {
                number = nameOrNumber; // calling + name
                whichElement = i;
            }
        }

        if (number == "")
        {
            result += "calling " + phoneNumberOwner[whichElement] + "..." + Environment.NewLine;
        }

        if (name == "")
        {
            result += "calling " + phoneNumbersInArray[whichElement] + "..." + Environment.NewLine;
        }

        int sumDigitsOfPhoneNumber = 0;
        string phoneNumber = phoneNumbersInArray[whichElement];

        for (int i = 0; i < phoneNumber.Length; i++)
        {
            char digit = phoneNumber[i];

            if (digit == '0' || digit == '1' || digit == '2' || digit == '3' || digit == '4'
                || digit == '5' || digit == '6' || digit == '7' || digit == '8' || digit == '9')
            {
                int digitAsNumber = digit - 48; // because of ASCII
                sumDigitsOfPhoneNumber += digitAsNumber;
            }
        }

        int minutes = 0;
        int seconds = 0;
        string addZeroForMinutes = "";
        string addZeroForSeconds = "";

        if (sumDigitsOfPhoneNumber % 2 != 0)
        {
            result += "no answer" + Environment.NewLine;
        }

        else
        {
            result += "call ended.";
            minutes = sumDigitsOfPhoneNumber / 60;
            seconds = sumDigitsOfPhoneNumber - minutes * 60;

            if (minutes < 10)
            {
                addZeroForMinutes = "0";
            }

            if (seconds < 10)
            {
                addZeroForSeconds = "0";
            }
            result += " duration: " + addZeroForMinutes + minutes + ":" +
                addZeroForSeconds + seconds + Environment.NewLine; ;
        }
        return result;
    }
}

