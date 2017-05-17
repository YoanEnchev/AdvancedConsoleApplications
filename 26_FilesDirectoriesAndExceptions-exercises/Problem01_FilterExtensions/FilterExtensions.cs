using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class FilterExtensions
{
    static void Main()
    {
        string extension = Console.ReadLine();
        string result = "";

        List<string> filesPath = Directory
            .GetFiles("input")
            .ToList();

        for (int i = 0; i < filesPath.Count; i++)
        {
            List<string> filePathAndExtension = filesPath[i]
                .Split('.')
                .ToList();

            string fileExtension = filePathAndExtension.Last();

            if (extension == fileExtension)
            {
                string[] pathAndFileName = filesPath[i].Split('\\');
                result += pathAndFileName[1] + Environment.NewLine;
            }
        }

        Console.WriteLine(result);
    }
}

