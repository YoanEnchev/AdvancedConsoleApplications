using System;

class RotateArrayOfStrings
{
    static void Main()
    {
        string values = Console.ReadLine();
        string[] inputValues = values.Split(' ');

        string elementsWithoutLastOne = "";
        string lastElement = "";

        for (int i = 0; i < inputValues.Length; i++)
        {
            if (i != inputValues.Length - 1)
            {
                elementsWithoutLastOne += inputValues[i] + " ";
            }

            else
            {
                lastElement += inputValues[i] + " ";
            }
        }

        Console.WriteLine(lastElement + elementsWithoutLastOne);
    }
}
