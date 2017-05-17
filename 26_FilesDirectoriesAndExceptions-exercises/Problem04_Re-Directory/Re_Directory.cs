using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Re_Directory
{
    static void Main()
    {
        string[] filesPath = Directory.GetFiles("04. Re-Directory/input");
        var allExtensions = new HashSet<string>();

        for (int i = 0; i < filesPath.Length; i++)
        {
            string[] filePathAndExtension = filesPath[i].Split('.');
            string extension = filePathAndExtension[filePathAndExtension.Length - 1];
            allExtensions.Add(extension);
        }

        List<string> extensions = allExtensions.ToList();

        for (int i = 0; i < extensions.Count; i++)
        {
            string directoryName = $"{extensions[i]}s";
            Directory.CreateDirectory($"04. Re-Directory/input/{directoryName}");
            string[] files = Directory.GetFiles("04. Re-Directory/input", $"*.{extensions[i]}");
            FileInfo file = new FileInfo(files[i]);

            file.CopyTo(Path.Combine("04. Re-Directory/input", file.Name), true);
        }

    }
}



