using System;

class DataOverflow
{
    static void Main()
    {

        decimal NumberOne = ulong.Parse(Console.ReadLine());
        decimal NumberTwo = ulong.Parse(Console.ReadLine());
        decimal BiggerNumber;
        decimal SmallerNumber;
        string type = " ";
        decimal Overflown = 0;

        if (NumberOne >= NumberTwo)
        {
            BiggerNumber = NumberOne;
            SmallerNumber = NumberTwo;
        }
        else
        {
            BiggerNumber = NumberTwo;
            SmallerNumber = NumberOne;
        }

        if (BiggerNumber <= 255)
        {
            Console.WriteLine("bigger type: byte");
        }

        else if (BiggerNumber <= 65535)
        {
            Console.WriteLine("bigger type: ushort ");
        }

        else if (BiggerNumber <= 4294967295)
        {
            Console.WriteLine("bigger type: uint ");
        }
        else if (BiggerNumber > 4294967295)
        {
            Console.WriteLine("bigger type: ulong ");
        }





        if (SmallerNumber <= 255)
        {
            Console.WriteLine("smaller type: byte");
            type = "byte";
        }

        else if (SmallerNumber <= 65535)
        {
            Console.WriteLine("smaller type: ushort ");
            type = "ushort";
        }

        else if (SmallerNumber <= 4294967295)
        {
            Console.WriteLine("smaller type: uint ");
            type = "uint";
        }
        else if (SmallerNumber > 4294967295)
        {
            Console.WriteLine("smaller type: ulong ");
            type = "ulong";
        }

        if (type == "byte")
        {
            Overflown = BiggerNumber / byte.MaxValue;
        }

        if (type == "ushort")
        {
            Overflown = BiggerNumber / ushort.MaxValue;
        }

        if (type == "uint")
        {
            Overflown = BiggerNumber / uint.MaxValue;
        }

        if (type == "ulong")
        {
            Overflown = BiggerNumber / ulong.MaxValue;

        }

        Console.WriteLine("{0} can overflow {1} {2} times", BiggerNumber, type, Math.Round(Overflown));

    }
}

