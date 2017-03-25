using System;

class SoecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isItSpecial = false;

        for (int i = 1; i <= n; i++)
        {
            int nImitator = n;
            int iImitator = i;
            int sum = 0;


            while (iImitator > 0)
            {
                sum += iImitator % 10;
                iImitator = iImitator / 10;
            }

            if (sum == 5 || sum == 7 || sum == 11)
            {
                isItSpecial = true;
            }
            else
            {
                isItSpecial = false;
            }

            Console.WriteLine("{0} -> {1}", i, isItSpecial);
        }
    }
}

