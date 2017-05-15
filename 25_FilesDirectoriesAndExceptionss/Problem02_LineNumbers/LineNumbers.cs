using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        string allWordsAndLines = File.ReadAllText("Input.txt");

        var allLines = allWordsAndLines.Split('\n').ToList();
        var numberedAllLines = new List<string>();

        for (int i = 0; i < allLines.Count; i++)
        {
            numberedAllLines.Add($"{i + 1}. {allLines[i]}");
        }

        File.WriteAllLines("Number All Lines.txt", numberedAllLines);
    }
}

