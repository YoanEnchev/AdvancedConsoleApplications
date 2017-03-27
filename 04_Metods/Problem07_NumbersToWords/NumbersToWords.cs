using System;

class NumbersToWords
{
    static void Main()
    {
        string result = "";
        int HowManyTimes = int.Parse(Console.ReadLine());
        for (int i = 1; i <= HowManyTimes; i++)
        {
            int number = int.Parse(Console.ReadLine());
            result += (PrintTheNumber(number, i, HowManyTimes));
        }
        Console.WriteLine(result);
    }
    static string PrintTheNumber(int number, int i, int HowManyTimes)
    {
        bool dontGoThrough = false;
        string result = "";


        if (number > 999)
        {
            result = "too large\n";
            dontGoThrough = true;
        }

        else if (number < -999)
        {
            result = "too small\n";
            dontGoThrough = true;
        }

        else if (number > -100 && number < 100)
        {
            dontGoThrough = true;
        }

        if (dontGoThrough == false)
        {
            string Minus = "";
            string and = "and";


            if (number <= -100)
            {
                Minus = "minus ";
            }
            else
            {
                Minus = "";
            }

            number = Math.Abs(number);

            int hundred = number / 100;
            int one = number % 10;
            int ten = (number / 10) % 10;

            string Printhundred = "";
            string PrintTen = "";
            string PrintOne = "";

            switch (hundred)
            {
                case 1:
                    Printhundred = "one";
                    break;
                case 2:
                    Printhundred = "two";
                    break;
                case 3:
                    Printhundred = "three";
                    break;
                case 4:
                    Printhundred = "four";
                    break;
                case 5:
                    Printhundred = "five";
                    break;
                case 6:
                    Printhundred = "six";
                    break;
                case 7:
                    Printhundred = "seven";
                    break;
                case 8:
                    Printhundred = "eight";
                    break;
                case 9:
                    Printhundred = "nine";
                    break;
            }

            switch (ten)
            {
                case 0:
                    PrintTen = "";
                    break;
                case 1:
                    PrintTen = "";
                    one = one + 10;
                    break;
                case 2:
                    PrintTen = "twenty";
                    break;
                case 3:
                    PrintTen = "thirty";
                    break;
                case 4:
                    PrintTen = "fourty";
                    break;
                case 5:
                    PrintTen = "fifty";
                    break;
                case 6:
                    PrintTen = "sixty";
                    break;
                case 7:
                    PrintTen = "seventy";
                    break;
                case 8:
                    PrintTen = "eighty";
                    break;
                case 9:
                    PrintTen = "ninety";
                    break;
            }

            switch (one)
            {
                case 0:
                    PrintOne = "";
                    break;
                case 1:
                    PrintOne = "one";
                    break;
                case 2:
                    PrintOne = "two";
                    break;
                case 3:
                    PrintOne = "three";
                    break;
                case 4:
                    PrintOne = "four";
                    break;
                case 5:
                    PrintOne = "five";
                    break;
                case 6:
                    PrintOne = "six";
                    break;
                case 7:
                    PrintOne = "seven";
                    break;
                case 8:
                    PrintOne = "eight";
                    break;
                case 9:
                    PrintOne = "nine";
                    break;
                case 10:
                    PrintOne = "ten";
                    break;
                case 11:
                    PrintOne = "eleven";
                    break;
                case 12:
                    PrintOne = "twelve";
                    break;
                case 13:
                    PrintOne = "thirteen";
                    break;
                case 14:
                    PrintOne = "fourteen";
                    break;
                case 15:
                    PrintOne = "fifteen";
                    break;
                case 16:
                    PrintOne = "sixteen";
                    break;
                case 17:
                    PrintOne = "seventeen";
                    break;
                case 18:
                    PrintOne = "eighteen";
                    break;
                case 19:
                    PrintOne = "nineteen";
                    break;
            }

            if (one == 0 && ten == 0)
            {
                and = "";
            }

            string extraSpace = "";
            if (ten > 1 && one != 0)
            {
                extraSpace = " ";
            }

            result = (($"{Minus}{Printhundred}-hundred {and} {PrintTen}{extraSpace}{PrintOne}\n"));
        }
        return result;
    }
}

