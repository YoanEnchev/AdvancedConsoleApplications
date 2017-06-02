using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class HornetArmada
{
    static void Main()
    {
        var legionsData = new List<Legion>();

        long count = long.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            string[] tokens = input
                .Split(new[] { "->", "=", ":" }, StringSplitOptions.None);

            int lastActivity = int.Parse(tokens[0].Trim());
            string legionName = tokens[1].Trim();
            string soildierType = tokens[2].Trim();
            long soiderCount = long.Parse(tokens[3].Trim());

            bool legionIsAlreadyRegistered = CheckIsThereLegionWithSameName(legionsData, legionName);

            if (legionIsAlreadyRegistered)
            {
                legionsData = UpdateLegionData(lastActivity, legionName, soildierType, soiderCount, legionsData);
            }

            else
            {
                var soilderAndCount = new Dictionary<string, long>();
                soilderAndCount[soildierType] = soiderCount;

                Legion notRegistered = new Legion
                {
                    legionName = legionName,
                    lastActivity = lastActivity,
                    typeAndCountSoilder = soilderAndCount
                };

                legionsData.Add(notRegistered);
            }

            input = Console.ReadLine();
        }

        ReadCommandForResultAndPrintResult(legionsData, input);
    }

    public static void ReadCommandForResultAndPrintResult(List<Legion> legionsData, string command)
    {
        if (command.Contains("\\")) //not valid command?
        {
            string[] input = command.Split('\\');
            int lastActivity = int.Parse(input[0]);
            string soilderType = input[1];

            legionsData = legionsData
                .Where(x => x.typeAndCountSoilder.ContainsKey(soilderType))
                .Where(x => x.lastActivity < lastActivity)
                .OrderByDescending(x => x.typeAndCountSoilder.Values.Sum()) //?yes
                .ToList();
     
            for (int i = 0; i < legionsData.Count; i++)
            {
                var typeAndCount = legionsData[i]
                    .typeAndCountSoilder
                    .ToDictionary(x => x.Key, y=> y.Value);

                typeAndCount = typeAndCount
                    .Where(x => x.Key == soilderType)
                    .ToDictionary(x => x.Key, y => y.Value);

                Console.WriteLine($"{legionsData[i].legionName} -> {typeAndCount.Values.First()}"); //?yes
            }
        }

        else
        {
            string soilderType = command;

            legionsData = legionsData
                .Where(x => x.typeAndCountSoilder.ContainsKey(soilderType))
                .OrderByDescending(x => x.lastActivity)
                .ToList();

            foreach (var legion in legionsData)
            {
                Console.WriteLine($"{legion.lastActivity} : {legion.legionName}");//?
            }
        }
    }

    public static List<Legion> UpdateLegionData(int lastActivity, string legionName, string soildierType, long soiderCount, List<Legion> legionsData)
    {
        for (int i = 0; i < legionsData.Count; i++)
        {
            if (legionName == legionsData[i].legionName)
            {
                if (legionsData[i].lastActivity < lastActivity)
                {
                    legionsData[i].lastActivity = lastActivity; //last activity
                }

                if (legionsData[i].typeAndCountSoilder.ContainsKey(soildierType)) //registered soilder type
                {
                    var typesAndSoildersCount = legionsData[i].typeAndCountSoilder;

                    typesAndSoildersCount[soildierType] += soiderCount;
                    legionsData[i].typeAndCountSoilder = typesAndSoildersCount;
                }

                else
                {
                    legionsData[i].typeAndCountSoilder.Add(soildierType, soiderCount); // not registered soilder type
                }
            }
        }

        return legionsData;
    }

    public static bool CheckIsThereLegionWithSameName(List<Legion> legionsData, string legionName)
    {
        bool isRegistered = false;

        for (int i = 0; i < legionsData.Count; i++)
        {
            if (legionsData[i].legionName == legionName)
            {
                isRegistered = true;
            }
        }

        return isRegistered;
    }
}

