using System;

class SweetDessert
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        int guests = int.Parse(Console.ReadLine());
        decimal oneBanana_price = decimal.Parse(Console.ReadLine());
        decimal oneEgg_price = decimal.Parse(Console.ReadLine());
        decimal kiloBerries_price = decimal.Parse(Console.ReadLine());

        decimal deserts_count = Math.Ceiling((decimal)(guests) / 6);
        decimal priceForOneDessert = 2 * oneBanana_price + 4 * oneEgg_price + (decimal)0.2 * kiloBerries_price;
        decimal priceForAllDesserts = deserts_count * priceForOneDessert;

        if (cash >= priceForAllDesserts)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {priceForAllDesserts:F2}lv.");
        }

        else
        {
            decimal neededMoreMoney = priceForAllDesserts - cash;
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoreMoney:F2}lv more.");
        }
    }
}

