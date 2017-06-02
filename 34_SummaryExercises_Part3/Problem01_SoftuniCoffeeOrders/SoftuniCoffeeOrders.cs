using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

public class SoftuniCoffeeOrders
{
    public static void Main()
    {
        int ordersCount = int.Parse(Console.ReadLine());
        string format = "d/M/yyyy";
        var prices = new List<decimal>();

        for (int i = 0; i < ordersCount; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
            int capsuleCount = int.Parse(Console.ReadLine());

            int year = orderDate.Year;
            int month = orderDate.Month;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            decimal price = (decimal)daysInMonth * (decimal)capsuleCount * pricePerCapsule; ;
            prices.Add(price);
        }

        PrintResult(prices);
    }

    public static void PrintResult(List<decimal> prices)
    {
        for (int i = 0; i < prices.Count; i++)
        {
            Console.WriteLine($"The price for the coffee is: ${prices[i]:F2}");
        }

        Console.WriteLine($"Total: ${prices.Sum():F2}");
    }
}

