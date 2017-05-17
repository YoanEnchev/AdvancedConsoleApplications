using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Products
{
    static void Main()
    {
        var products = new List<Product>();
        products = ReadInformationFromFile();

        string input = Console.ReadLine();

        while (input != "exit")
        {

            if (input == "sales")
            {

                string food = "Food";
                string electronics = "Electronics";
                string domestics = "Domestics";

                List<Product> stokenElectronics = GetProductsOfType(electronics, products);
                List<Product> stockedDomestics = GetProductsOfType(domestics, products);
                List<Product> stokedFood = GetProductsOfType(food, products);

                GetAndPrintIncomeForEachType(stokenElectronics, stockedDomestics, stokedFood);
            }

            else if (input == "analyze")
            {
                List<Product> stockedProducts = ReadInformationFromFile();
                stockedProducts = stockedProducts
                    .OrderBy(x => x.type)
                    .ToList();

                if (stockedProducts.Count > 0)
                {
                    for (int i = 0; i < stockedProducts.Count; i++)
                    {
                        Console.WriteLine($"{stockedProducts[i].type}, Product: {stockedProducts[i].name}");
                        Console.WriteLine($"Price: ${stockedProducts[i].price}, Amount Left: {stockedProducts[i].quantity}");
                    }
                }

                else
                {
                    Console.WriteLine("No products stocked");
                }
            }

            else if (input == "stock")
            {
                GetInformationAndWriteItOnFile(products);
            }

            else
            {
                string[] inputTokens = input.Split(' ');

                string name = inputTokens[0];
                string type = inputTokens[1];
                decimal price = decimal.Parse(inputTokens[2]);
                int quantity = int.Parse(inputTokens[3]);

                bool isThereTheSameProduct = CheckIsProductRegistered(name, type, products);

                if (isThereTheSameProduct)
                {
                    products = ChangePriceAndQuantity(price, quantity, name, type, products);
                }

                else
                {
                    Product currentProduct = new Product
                    {
                        name = name,
                        type = type,
                        price = price,
                        quantity = quantity
                    };

                    products.Add(currentProduct);
                }
            }

            input = Console.ReadLine();
        }
    }

    public static void GetAndPrintIncomeForEachType(List<Product> stokenElectronics, List<Product> stockedDomestics, List<Product> stokedFood)
    {

        decimal sumOfElectronics = 0;
        decimal sumODomestics = 0;
        decimal sumOfFood = 0;

        for (int i = 0; i < stokenElectronics.Count; i++)
        {
            decimal currentProductIncome = stokenElectronics[i].quantity * stokenElectronics[i].price;
            sumOfElectronics += currentProductIncome;
        }

        for (int i = 0; i < stockedDomestics.Count; i++)
        {
            decimal currentProductIncome = stockedDomestics[i].quantity * stockedDomestics[i].price;
            sumODomestics += currentProductIncome;
        }

        for (int i = 0; i < stokedFood.Count; i++)
        {
            decimal currentProductIncome = stokedFood[i].quantity * stokedFood[i].price;
            sumOfFood += currentProductIncome;
        }

        decimal[] sums = { sumOfElectronics, sumODomestics, sumOfFood };
        sums = sums
            .OrderByDescending(x => x)
            .ToArray();

        bool isElectronic = true;
        bool isDomestic = true; //sumElectronics = sumDomestics
        bool isFood = true;

        for (int i = 0; i < sums.Length; i++)
        {
            string type = "";

            if (sums[i] != 0)
            {
                if (sums[i] == sumOfElectronics && isElectronic)
                {
                    type = "Electronics";
                    isElectronic = false;
                    Console.WriteLine($"{type}: ${sums[i]:F2}");
                }

                else if (sums[i] == sumOfFood && isFood)
                {
                    type = "Food";
                    isFood = false;
                    Console.WriteLine($"{type}: ${sums[i]:F2}");
                }

                else if (sums[i] == sumODomestics && isDomestic)
                {
                    type = "Domestics";
                    isDomestic = false;
                    Console.WriteLine($"{type}: ${sums[i]:F2}");
                }
            }
        }
    }

    public static List<Product> GetProductsOfType(string type, List<Product> products)
    {
        List<Product> productsOfType = new List<Product>();

        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].type == type)
            {
                productsOfType.Add(products[i]);
            }
        }

        return productsOfType;
    }

    public static List<Product> ReadInformationFromFile()
    {
        string[] productsInformation = File.ReadAllLines("Products information.txt");
        List<Product> products = new List<Product>();

        for (int i = 0; i < productsInformation.Length; i++)
        {
            string[] currentProdut = productsInformation[i]
                 .Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

            string name = currentProdut[0];
            string type = currentProdut[1];
            decimal price = decimal.Parse(currentProdut[2]);
            int quantity = int.Parse(currentProdut[3]);

            Product currentProduct = new Product
            {
                name = name,
                type = type,
                price = price,
                quantity = quantity
            };

            products.Add(currentProduct);
        }

        return products;
    }

    public static void GetInformationAndWriteItOnFile(List<Product> products)
    {
        string result = "";

        for (int i = 0; i < products.Count; i++)
        {
            result += $"{products[i].name} - {products[i].type} - {products[i].price} - {products[i].quantity}";
            result += Environment.NewLine;
        }

        File.WriteAllText("Products information.txt", result);
    }

    public static List<Product> ChangePriceAndQuantity(decimal price, int quantity, string name, string type, List<Product> products)
    {
        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].type == type && products[i].name == name)
            {
                products[i].price = price;
                products[i].quantity = quantity;
            }
        }

        return products;
    }

    public static bool CheckIsProductRegistered(string name, string type, List<Product> products)
    {
        bool isRegistered = false;

        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].type == type && products[i].name == name)
            {
                isRegistered = true;
            }
        }

        return isRegistered;
    }
}

