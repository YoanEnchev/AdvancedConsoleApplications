using System;

class CypherRoulette
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = "";
        string previous = "";

        int goToRightOrLeftSide = 0;
        bool IsItSpinned = false; ;

        string left = "";
        string main = "";
        string right = "";

        for (int i = 1; i <= n; i++)
        {
            input = Console.ReadLine();
            if (input.Equals("spin"))
            {
                IsItSpinned = true;
                input = "";
                goToRightOrLeftSide++;
                i--;
            }


            if (IsItSpinned = true)
            {
                if (goToRightOrLeftSide % 2 != 0)
                {
                    left += input + left;
                }

                if (goToRightOrLeftSide % 2 == 0)
                {
                    right = right + input;
                }
            }

            if (IsItSpinned == false)
            {
                main += input;
            }

            if (previous == input)
            {
                left = String.Empty;
                right = String.Empty;
                main = String.Empty;
            }
            previous = input;
        }
        Console.WriteLine(left + main + right);
    }
}

