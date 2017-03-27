using System;

class BlankReceipt
{
  
    static void Main()
    {
        Header();
        Body();
        Footer();
    }


    static void Header()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }
    static void Body()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }
    static void Footer()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("\u00A9 SoftUni");
    }
}


