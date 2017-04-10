using System;
using System.Collections.Generic;
using System.Linq;

class NoteStatistics
{
    static void Main()
    {
        //Console.Beep(392, 5000);
        string sequenceOfFrequency = Console.ReadLine();
        List<string> frequency_asString = sequenceOfFrequency.Split(' ').ToList();

        List<double> frequency = new List<double>();
        frequency = ConvertItToDouble(frequency_asString);

        List<string> frequencyAsNotes = TurnFrequencyIntoNotes(frequency);
        List<string> naturalsNotes = GetNaturalNotes(frequencyAsNotes);
        List<string> sharpNotes = GetSharpNotes(frequencyAsNotes);

        double[] sum = new double[2];
        sum = GetSumOfNaturalAndSharpNotes(frequencyAsNotes);

        double sum_Naturals = sum[0];
        double sum_Sharps = sum[1];

        PrintResult(frequencyAsNotes, naturalsNotes, sharpNotes, sum_Naturals, sum_Sharps);
    }

    public static List<double> ConvertItToDouble(List<string> frequency_asString)
    {
        List<double> frequency = new List<double>();

        for (int i = 0; i < frequency_asString.Count; i++)
        {
            frequency.Add(double.Parse(frequency_asString[i]));
        }
        return frequency;
    }

    public static void PrintResult(List<string> frequencyAsNotes, List<string> naturalsNotes, List<string> sharpNotes, double sum_Naturals, double sum_Sharps)
    {
        Console.Write("Notes: ");

        for (int i = 0; i < frequencyAsNotes.Count; i++)
        {
            if (i != frequencyAsNotes.Count - 1)
            {
                Console.Write(frequencyAsNotes[i] + " ");
            }
            else
            {
                Console.Write(frequencyAsNotes[i]);
            }
        }

        Console.WriteLine();
        Console.Write("Naturals: ");

        for (int i = 0; i < naturalsNotes.Count; i++)
        {
            if (i != naturalsNotes.Count - 1)
            {
                Console.Write(naturalsNotes[i] + ", ");
            }

            else
            {
                Console.Write(naturalsNotes[i]);
            }
        }

        Console.WriteLine();
        Console.Write("Sharps: ");

        for (int i = 0; i < sharpNotes.Count; i++)
        {
            if (i != sharpNotes.Count - 1)
            {
                Console.Write(sharpNotes[i] + ", ");
            }

            else
            {
                Console.Write(sharpNotes[i]);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Naturals sum: {sum_Naturals}");
        Console.WriteLine($"Sharps sum: {sum_Sharps}");
    }

    public static double[] GetSumOfNaturalAndSharpNotes(List<string> frequencyAsNotes)
    {
        double[] sumOfNaturalsAndSharp = new double[2];
        double sum_naturals = 0;
        double sum_sharps = 0;
        for (int i = 0; i < frequencyAsNotes.Count; i++)
        {
            switch (frequencyAsNotes[i])
            {
                case "C":
                    sum_naturals += 261.63;
                    break;

                case "C#":
                    sum_sharps += 277.83;
                    break;

                case "D":
                    sum_naturals += 293.66;
                    break;

                case "D#":
                    sum_sharps += 311.13;
                    break;

                case "E":
                    sum_naturals += 329.63;
                    break;

                case "F":
                    sum_naturals += 349.23;
                    break;

                case "F#":
                    sum_sharps += 369.99;
                    break;

                case "G":
                    sum_naturals += 392.0;
                    break;

                case "G#":
                    sum_sharps += 415.30;
                    break;

                case "A":
                    sum_naturals += 440.0;
                    break;

                case "A#":
                    sum_sharps += 466.16;
                    break;

                case "B":
                    sum_naturals += 493.88;
                    break;
            }
        }
        sumOfNaturalsAndSharp[0] = sum_naturals;
        sumOfNaturalsAndSharp[1] = sum_sharps;
        return sumOfNaturalsAndSharp;
    }

    public static List<string> GetSharpNotes(List<string> frequencyAsNotes)
    {
        List<string> sharpNotes = new List<string>();

        for (int i = 0; i < frequencyAsNotes.Count; i++)
        {
            if (frequencyAsNotes[i].Contains("#"))
            {
                sharpNotes.Add(frequencyAsNotes[i]);
            }
        }
        return sharpNotes;
    }

    public static List<string> GetNaturalNotes(List<string> frequencyAsNotes)
    {
        List<string> NaturalNotes = new List<string>();

        for (int i = 0; i < frequencyAsNotes.Count; i++)
        {
            if (!frequencyAsNotes[i].Contains("#"))
            {
                NaturalNotes.Add(frequencyAsNotes[i]);
            }
        }
        return NaturalNotes;
    }

    public static List<string> TurnFrequencyIntoNotes(List<double> frequency)
    {
        List<string> notes = new List<string>();
        for (int i = 0; i < frequency.Count; i++)
        {
            double currentFrequency = frequency[i];

            if (currentFrequency == 261.63)
            {
                notes.Add("C");
            }

            if (currentFrequency == 277.18)
            {
                notes.Add("C#");
            }

            if (currentFrequency == 293.66)
            {
                notes.Add("D");
            }

            if (currentFrequency == 311.13)
            {
                notes.Add("D#");
            }

            if (currentFrequency == 329.63)
            {
                notes.Add("E");
            }

            if (currentFrequency == 349.23)
            {
                notes.Add("F");
            }

            if (currentFrequency == 369.99)
            {
                notes.Add("F#");
            }

            if (currentFrequency == 392)
            {
                notes.Add("G");
            }

            if (currentFrequency == 415.30)
            {
                notes.Add("G#");
            }

            if (currentFrequency == 440)
            {
                notes.Add("A");
            }

            if (currentFrequency == 466.16)
            {
                notes.Add("A#");
            }

            if (currentFrequency == 493.88)
            {
                notes.Add("B");
            }
        }
        return notes;
    }
}
