using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


public class Files
{
    public static void Main()
    {
        int howMany = int.Parse(Console.ReadLine());
        List<File> fileData = new List<File>();

        for (int i = 0; i < howMany; i++)
        {
            File currentFile = ReadFileData();

            fileData = DeleteIfThereIsAFileInTheRootWithSameNameAndExc(currentFile, fileData); //the file
            fileData.Add(currentFile);
        }

        string[] extensionAndRoot = Console.ReadLine().Split(new[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

        SortAndPrintResult(extensionAndRoot, fileData);
    }

    public static void SortAndPrintResult(string[] extensionAndRoot, List<File> fileData)
    {
        fileData = fileData.OrderByDescending(x => x.size)
            .ThenBy(x => x.name)
            .ToList();

        string extension = extensionAndRoot[0];
        string root = extensionAndRoot[2];

        bool fileWasPrinted = false;

        for (int i = 0; i < fileData.Count; i++)
        {
            File currentFile = fileData[i];

            if (currentFile.extension == extension && currentFile.root == root)
            {
                Console.WriteLine($"{currentFile.name}.{currentFile.extension} - {currentFile.size} KB");
                fileWasPrinted = true;
            }
        }

        if (!fileWasPrinted)
        {
            Console.WriteLine("No");
        }

    }

    public static List<File> DeleteIfThereIsAFileInTheRootWithSameNameAndExc(File currentFile, List<File> fileData)
    {
        for (int i = 0; i < fileData.Count; i++)
        {
            File registeredFile = fileData[i];

            if (registeredFile.root == currentFile.root && registeredFile.name == currentFile.name
                && registeredFile.extension == currentFile.extension)
            {
                fileData.RemoveAt(i);
            }
        }

        return fileData;
    }

    public static File ReadFileData()
    {
        string input = Console.ReadLine().Trim();
        string[] tokens = input.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();

        string fileNameAndSize = tokens[tokens.Length - 1].Trim();
        string[] fileNameAndSizeSeparated = fileNameAndSize.Split(';')
            .Select(x => x.Trim())
            .ToArray();

        string fileNameAndExtension = fileNameAndSizeSeparated[0].Trim();
        BigInteger fileSize = BigInteger.Parse(fileNameAndSizeSeparated[1].Trim()); //jic

        string[] fileNameAndExtension_separated = fileNameAndExtension.Split('.');
        string extension = fileNameAndExtension_separated[fileNameAndExtension_separated.Length - 1];

        string fileName = fileNameAndExtension.Replace("." + extension, string.Empty);

        string path = input.Replace("\\"+fileNameAndSize, string.Empty);//!
        string[] elementsOfPath = path.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
        string root = elementsOfPath[0].Trim();


        File newFile = new File
        {
            root = root,
            path = path,
            name = fileName,
            extension = extension,
            size = fileSize
        };

        return newFile;
    }
}

//C:\Documents\01. problems.docx;6521 01 -> name