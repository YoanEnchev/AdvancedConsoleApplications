using System;
using System.Collections.Generic;
using System.Linq;

class ExamShopping
{
    static void Main()
    {
        Dictionary<string, int> productAndQuantity = new Dictionary<string, int>();
        string[] commandProductAndQuantity = Console.ReadLine().Split(' ');

        while (!commandProductAndQuantity.Contains("shopping")) // stash
        {
            productAndQuantity = Stocking(commandProductAndQuantity, productAndQuantity);
            commandProductAndQuantity = Console.ReadLine().Split(' ');
        }

        if (commandProductAndQuantity.Contains("shopping"))
        {
            commandProductAndQuantity = Console.ReadLine().Split(' ');
        }

        while (!commandProductAndQuantity.Contains("exam")) //sell time
        {
            productAndQuantity = Selling(commandProductAndQuantity, productAndQuantity);
            commandProductAndQuantity = Console.ReadLine().Split(' ');
        }

        ExamTime(productAndQuantity);

    }

    public static void ExamTime(Dictionary<string, int> productAndQuantity)
    {
        foreach (var item in productAndQuantity)
        {
            if (item.Value > 0)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }

    public static Dictionary<string, int> Selling(string[] commandProductAndQuantity, Dictionary<string, int> productAndQuantity)
    {
        string wantedProduct = commandProductAndQuantity[1];
        int quantity = int.Parse(commandProductAndQuantity[2]);
        bool hasItEverExisted = false;


        if (productAndQuantity.ContainsKey(wantedProduct))
        {
            hasItEverExisted = true;
        }

        if (hasItEverExisted == false)
        {
            Console.WriteLine($"{wantedProduct} doesn't exist");
        }

        if (hasItEverExisted == true)
        {
            if (productAndQuantity[wantedProduct] < 1)
            {
                Console.WriteLine($"{wantedProduct} out of stock");
            }

            else
            {
                productAndQuantity[wantedProduct] -= quantity;
            }
        }
        return productAndQuantity;
    }

    public static Dictionary<string, int> Stocking(string[] commandProductAndQuantity, Dictionary<string, int> productAndQuantity)
    {
        string command = commandProductAndQuantity[0];
        string product = commandProductAndQuantity[1];
        int quantity = int.Parse(commandProductAndQuantity[2]);

        bool isItAlreadyInStash = false;

        if (productAndQuantity.ContainsKey(product))
        {
            isItAlreadyInStash = true;
        }

        if (isItAlreadyInStash == false)
        {
            productAndQuantity[product] = quantity;
        }

        else
        {
            productAndQuantity[product] += quantity;
        }

        return productAndQuantity;
    }
}
