using System;
using System.Collections.Generic;
using System.Linq;

class DictRef
{
    static void Main()
    {
        Dictionary<string, int> nameAndValueInDictionary = new Dictionary<string, int>();
        List<string> namesOfElementsInDictionary = new List<string>();
        string value = "";
        string name;

        string nameAndValue_input = Console.ReadLine();

        while (nameAndValue_input != "end")
        {
            string[] currentNameAndValue = nameAndValue_input.Split(' ');
            bool isNameContainedInDictionary = CheckIfNameIsContainedinDictionary(currentNameAndValue[2], namesOfElementsInDictionary);

            if (isNameContainedInDictionary == true)
            {
                name = currentNameAndValue[0];
                value = currentNameAndValue[2];
                namesOfElementsInDictionary.Add(name);

                string index = GetValue(nameAndValueInDictionary, namesOfElementsInDictionary, value);
                nameAndValueInDictionary[name] = nameAndValueInDictionary[index];
            }

            else
            {
                name = currentNameAndValue[0];
                value = currentNameAndValue[2];
                int value_int = int.Parse(value);
                value_int = int.Parse(currentNameAndValue[2]); // [1] = " "

                namesOfElementsInDictionary.Add(name);
                nameAndValueInDictionary[name] = value_int;
            }
            nameAndValue_input = Console.ReadLine();
        }
        PrintResult(nameAndValueInDictionary);
    }

    public static string GetValue(Dictionary<string, int> nameAndValueInDictionary, List<string> namesOfElementsInDictionary, string value)
    {
        string valueOfElementThatExists = "";

        for (int i = 0; i < namesOfElementsInDictionary.Count; i++)
        {
            if (value == namesOfElementsInDictionary[i])
            {
                valueOfElementThatExists = namesOfElementsInDictionary[i];
            }
        }

        return valueOfElementThatExists;
    }

    public static bool CheckIfNameIsContainedinDictionary(string value, List<string> namesOfElementsInDictionary)
    {
        bool isItContainedInDictionary = false;

        for (int i = 0; i < namesOfElementsInDictionary.Count; i++)
        {
            if (value == namesOfElementsInDictionary[i])
            {
                isItContainedInDictionary = true;
            }
        }

        return isItContainedInDictionary;
    }

    public static void PrintResult(Dictionary<string, int> nameAndValueInDictionary)
    {
        foreach (var item in nameAndValueInDictionary)
        {
            Console.WriteLine(item.Key + " === " + item.Value);
        }
    }
}
