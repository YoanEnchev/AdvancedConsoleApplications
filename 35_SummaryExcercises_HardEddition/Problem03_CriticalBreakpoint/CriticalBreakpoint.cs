using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class CriticalBreakpoint
{
    static void Main()
    {
        string input = Console.ReadLine();
        var lines = new List<Line>();

        while (input != "Break it.")
        {
            Line currentLine = ReadLine(input);
            lines.Add(currentLine);
            input = Console.ReadLine();
        }

        bool thereIsBreakpoint = CheckIfBreakpointIsFormed(lines);

        if(thereIsBreakpoint)
        {
            BigInteger ratio = GetRatioDiffrentFromZeroIfNotZero(lines);
            ratio = BigInteger.Pow(ratio, lines.Count);
            BigInteger result;
            BigInteger.DivRem(ratio, lines.Count, out result);
            PrintResult(result, lines);
        }

        else
        {
            Console.WriteLine("Critical breakpoint does not exist.");
        }
    }

    public static void PrintResult(BigInteger result, List<Line> lines)
    {
        for (int i = 0; i < lines.Count; i++)
        {
            Console.WriteLine($"Line: [{lines[i].x1}, {lines[i].y1}, {lines[i].x2}, {lines[i].y2}]");
        }

        Console.WriteLine($"Critical Breakpoint: {result}");
    }

    public static BigInteger GetRatioDiffrentFromZeroIfNotZero(List<Line> lines)
    {
        BigInteger ratio = 0;

        for (int i = 0; i < lines.Count; i++)
        {
            if(lines[i].criticalRatio != 0)
            {
                ratio = lines[i].criticalRatio;
                break;
            }
        }

        return ratio;
    }

    public static bool CheckIfBreakpointIsFormed(List<Line> lines)
    {
        bool rationIsEqualForAll = true;
        bool allNotZeroesAreEqual = true;

        for (int i = 0; i < lines.Count; i++)
        {
            BigInteger ratioOfFirst = lines[0].criticalRatio;

            if(lines[i].criticalRatio != ratioOfFirst)
            {
                rationIsEqualForAll = false;
            }
        }

        List<Line> noZeroRatio = lines
            .Where(x => x.criticalRatio != 0)
            .Take(1000)//all
            .ToList();

        for (int i = 0; i < noZeroRatio.Count; i++)
        {
            BigInteger ratioOfFirst = noZeroRatio[0].criticalRatio;

            if (noZeroRatio[i].criticalRatio != ratioOfFirst)
            {
                allNotZeroesAreEqual = false;
            }
        }

        bool breakpointIsFormed = rationIsEqualForAll || allNotZeroesAreEqual;

        return breakpointIsFormed;
    }

    public static Line ReadLine(string input)
    {
        long[] coordinates = input
                .Split(' ')
                .Select(x => long.Parse(x))
                .ToArray();

        long x1 = coordinates[0];
        long y1 = coordinates[1];
        long x2 = coordinates[2];
        long y2 = coordinates[3];

        Line currentLine = new Line
        {
            x1 = x1,
            y1 = y1,
            x2 = x2,
            y2 = y2
        };

        return currentLine;
    }
}

