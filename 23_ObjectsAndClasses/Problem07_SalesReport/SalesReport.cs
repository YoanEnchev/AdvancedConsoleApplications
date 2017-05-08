using System;
using System.Collections.Generic;
using System.Linq;

class SalesReport
{
    static void Main()
    {
        int howMany = int.Parse(Console.ReadLine());
        var TownAndMoneyFromSales = new SortedDictionary<string, decimal>();

        for (int i = 0; i < howMany; i++)
        {
            string[] town_product_price_quantity = Console.ReadLine().Split(' ');

            Sales report = ReadReport(town_product_price_quantity);

            if (!TownAndMoneyFromSales.ContainsKey(report.Town))
            {
                TownAndMoneyFromSales[report.Town] = report.Price * report.Quantity;
            }

            else
            {
                TownAndMoneyFromSales[report.Town] += report.Price * report.Quantity;
            }
        }

        PrintResult(TownAndMoneyFromSales);
    }

    public static Sales ReadReport(string[] town_product_price_quantity)
    {
        Sales report = new Sales
        {
            Town = town_product_price_quantity[0],
            Product = town_product_price_quantity[1],
            Price = decimal.Parse(town_product_price_quantity[2]),
            Quantity = decimal.Parse(town_product_price_quantity[3])
        };

        return report;
    }

    public static void PrintResult(SortedDictionary<string, decimal> townAndMoneyFromSales)
    {
        foreach (var town_money in townAndMoneyFromSales)
        {
            Console.WriteLine($"{ town_money.Key} -> {town_money.Value:F2}");
        }
    }
}

