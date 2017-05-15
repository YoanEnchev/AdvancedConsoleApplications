using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class OddLines
{
    static void Main()
    {
        string[] allLines = File.ReadAllLines("input.txt");
        var oddLines = new List<string>();

        for (int i = 1; i < allLines.Length; i += 2)
        {
            oddLines.Add(allLines[i]);
        }

        File.WriteAllLines("Odd Lines.Txt", oddLines);
    }
}

