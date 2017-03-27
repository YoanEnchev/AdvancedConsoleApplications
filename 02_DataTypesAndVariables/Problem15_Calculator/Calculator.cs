using System;

class Calculator
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        char ArithmeticOperator = char.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (ArithmeticOperator == '+')
        {
            Console.WriteLine("{0} {1} {2} = {3}", a, ArithmeticOperator, b, a + b);
        }


        if (ArithmeticOperator == '-')
        {
            Console.WriteLine("{0} {1} {2} = {3}", a, ArithmeticOperator, b, a - b);
        }

        if (ArithmeticOperator == '*')
        {
            Console.WriteLine("{0} {1} {2} = {3}", a, ArithmeticOperator, b, a * b);
        }

        if (ArithmeticOperator == '/')
        {
            Console.WriteLine("{0} {1} {2} = {3}", a, ArithmeticOperator, b, a / b);
        }

    }
}

