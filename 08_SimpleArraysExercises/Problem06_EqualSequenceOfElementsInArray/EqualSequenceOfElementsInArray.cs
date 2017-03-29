using System;

class EqualSequenceOfElementsInArray
{
    static void Main()
    {
        string values = Console.ReadLine();
        string[] numbers = values.Split(' ');

        int previousElement = 0;
        int currentElement;
        string areElementsTheSame = "Yes";

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                previousElement = int.Parse(numbers[i]);
            }

            else
            {
                currentElement = int.Parse(numbers[i]);

                if (previousElement != currentElement)
                {
                    areElementsTheSame = "No";
                }
                previousElement = currentElement;
            }
        }
        Console.WriteLine(areElementsTheSame);
    }
}

