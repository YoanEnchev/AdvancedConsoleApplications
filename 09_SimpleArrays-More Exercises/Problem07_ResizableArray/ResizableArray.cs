using System;

class ResizableArray
{
    static void Main()
    {
        string[] numbers = new string[4];
        string command = "";
        string number = "";

        while (command != "end")
        {
            string commandAndNumber = Console.ReadLine();
            string[] commandAndNumberAsArray = commandAndNumber.Split(' ');

            command = commandAndNumberAsArray[0];
            if (command != "end" && command != "pop" && command != "clear")
            {
                number = commandAndNumberAsArray[1];
            }

            if (command == "push")
            {
                numbers = Push(number, numbers);
            }

            if (command == "pop")
            {
                numbers = Pop(numbers);
            }

            if (command == "removeAt")
            {
                numbers = RemoveAt(number, numbers);
            }

            if (command == "clear")
            {
                numbers = Clear(numbers);
            }
        }
        PrintResult(numbers);
    }


    public static string[] Clear(string[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = null;
        }
        return numbers;
    }


    public static string[] RemoveAt(string number, string[] numbers)
    {
        numbers[int.Parse(number)] = null;
        return numbers;
    }


    public static string[] Pop(string[] numbers)
    {
        bool isElementRemoved = false;
        for (int i = numbers.Length - 1; i >= 0 && isElementRemoved == false; i--)
        {
            if (numbers[i] != null)
            {
                numbers[i] = null;
                isElementRemoved = true;
            }
        }
        return numbers;
    }


    public static string[] Push(string number, string[] numbers)
    {
        bool isElementAdded = false;
        for (int i = 0; i < numbers.Length && isElementAdded == false; i++)
        {
            if (numbers[i] == null)
            {
                numbers[i] = number;
                isElementAdded = true;
            }
        }

        bool isEveryElementNotNull = true; // check is there element = null
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == null)
            {
                isEveryElementNotNull = false;
            }
        }

        if (isEveryElementNotNull == true)
        {
            int newLenght = numbers.Length * 2;
            Array.Resize(ref numbers, newLenght);
        }
        return numbers;
    }


    public static void PrintResult(string[] numbers)
    {
        bool isThereElementThatIsNotNull = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != null)
            {
                isThereElementThatIsNotNull = true;
            }
        }

        if (isThereElementThatIsNotNull == true)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != null)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("empty array");
        }
    }
}

