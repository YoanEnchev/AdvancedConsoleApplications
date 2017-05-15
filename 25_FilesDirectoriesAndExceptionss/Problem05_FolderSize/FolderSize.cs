using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class FolderSize
{
    static void Main()
    {
        List<string> filesPath = Directory
               .GetFiles("05. Folder Size/TestFolder")
               .ToList();

        List<double> sizesInBytes = new List<double>();

        for (int i = 0; i < filesPath.Count; i++)
        {
            double fileSize = new FileInfo(filesPath[i]).Length;
            sizesInBytes.Add(fileSize);
        }

        double sizeInMB = sizesInBytes.Sum() / 1024 / 1024;

        File.WriteAllText("05. Folder Size/Size.txt", sizeInMB + "");
    }
}

