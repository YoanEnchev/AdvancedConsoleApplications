using System;

class RefactorSpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        bool isItSpecial = false;
        for (int i = 1; i <= n; i++)
        {
            int iImitator = i;
            while (i > 0)
            {
                sum += i % 10;
                i = i / 10;
            }
            isItSpecial = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{iImitator} -> {isItSpecial}");
            sum = 0;
            i = iImitator;
        }
    }
}
