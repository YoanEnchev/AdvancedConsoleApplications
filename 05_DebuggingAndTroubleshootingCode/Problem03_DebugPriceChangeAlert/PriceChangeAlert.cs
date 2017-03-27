using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        string message = "";

        for (int i = 1; i < n; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double diffrence = DiffrenceInProcent(price, nextPrice);
            bool isDiffrenceSignificant = IsTheDiffenceHigh(diffrence, threshold);

            message += HowMuchPriceHasChanged(nextPrice, price, diffrence, isDiffrenceSignificant);

            price = nextPrice;
        }
        Console.WriteLine(message);
    }

    private static string HowMuchPriceHasChanged(double nextPrice, double price, double diffrence, bool isDiffrenceSignificant)

    {
        string message = "";
        if (diffrence == 0)
        {
            message = string.Format("NO CHANGE: {0}\n", nextPrice);
        }

        else if (isDiffrenceSignificant == false && diffrence != 0)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)\n", price, nextPrice, diffrence * 100);
        }

        else if (isDiffrenceSignificant == true && (diffrence > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)\n", price, nextPrice, diffrence * 100);
        }

        else if (isDiffrenceSignificant && (diffrence < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)\n", price, nextPrice, diffrence * 100);
        }
        return message;
    }

    private static bool IsTheDiffenceHigh(double threshold, double isDiff)
    {
        if (Math.Abs(threshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double DiffrenceInProcent(double price, double nextPrice)
    {
        double procent = (nextPrice - price) / price;
        return procent;
    }
}

