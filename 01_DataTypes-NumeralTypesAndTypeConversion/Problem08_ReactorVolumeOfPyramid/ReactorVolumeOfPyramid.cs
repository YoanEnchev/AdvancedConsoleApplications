using System;

class ReactorVolumeOfPyramid
{
    static void Main()
    {
        double lenght, width, height, V;
        Console.Write("Length: ");
        lenght = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        height = double.Parse(Console.ReadLine());


        V = (lenght * width * height) / 3;
        Console.WriteLine("Pyramid Volume: {0:F2}", V);

    }
}

