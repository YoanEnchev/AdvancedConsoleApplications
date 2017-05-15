using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class MergeFiles
{
    static void Main()
    {
        List<string> allLinesOfNumbers_1 = File
            .ReadAllLines("04. Merge Files/FileOne.txt")
            .ToList();

        List<int> allNumbers_1 = allLinesOfNumbers_1
            .Select(x => int.Parse(x))
            .ToList();

        List<string> allLinesOfNumbers_2 = File
           .ReadAllLines("04. Merge Files/FileTwo.txt")
           .ToList();

        List<int> allNumbers_2 = allLinesOfNumbers_2
            .Select(x => int.Parse(x))
            .ToList();

        List<int> allNumbers = allNumbers_2
            .Concat(allNumbers_1)
            .ToList();

        allNumbers.Sort();

        List<string> allNumbers_string = allNumbers
            .Select(x => x + "")
            .ToList();

        File.WriteAllLines("04. Merge Files/Numbers.txt", allNumbers_string);
    }
}

