using System;

class SumArrayElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        int[] number = new int[n];
        for (int i = 0; i < number.Length; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
            sum += number[i];
        }
        Console.WriteLine(sum);
    }
}

