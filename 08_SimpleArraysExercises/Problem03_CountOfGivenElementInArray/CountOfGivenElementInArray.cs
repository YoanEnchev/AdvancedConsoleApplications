using System;

class CountOfGivenElementInArray
{
    static void Main()
    {
        string values = Console.ReadLine();
        string[] numbers = values.Split(' ');
        int counter = 0;

        int givenNumber = int.Parse(Console.ReadLine());
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == "" + givenNumber)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

