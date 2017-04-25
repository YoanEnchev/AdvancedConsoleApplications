using System;
using System.Collections.Generic;
using System.Linq;

class ForumTopics
{
    static void Main()
    {
        string input = Console.ReadLine();
        var data = new Dictionary<string, HashSet<string>>();

        while (input != "filter")
        {
            input = ReplaceCommaWithSpace(input);
            string[] topicAndTags = input.Split(' ');
            string topic = topicAndTags[0];

            if(!data.ContainsKey(topic))
            {
                data[topic] = new HashSet<string>();
            }

            HashSet<string> tags = new HashSet<string>();
            tags = AddAllInputedTags(topicAndTags, tags);
            data[topic] = AddTagsToTheTopic(tags,data[topic]);

            input = Console.ReadLine();
        }

        var filterWords = new List<string>();

        if(input == "filter")
        {          
            input = Console.ReadLine();
            input = ReplaceCommaWithSpace(input);
            filterWords = input.Split(' ').ToList();

            for (int i = 0; i < filterWords.Count; i++)
            {
                filterWords.Remove("");
            }
        }

        PrintResult(data,filterWords); //and check containment of filter words
    }

    public static void PrintResult(Dictionary<string, HashSet<string>> data, List<string> filterWords)
    {
        foreach (var kvp in data)
        {
            bool containsAllFilterWords = true;
            HashSet<string> tags = kvp.Value;

            for (int i = 0; i < filterWords.Count; i++)
            {
                if(!tags.Contains(filterWords[i]))
                {
                    containsAllFilterWords = false;
                }
            } 
            
            if(containsAllFilterWords == true)
            {
                Console.WriteLine($"{kvp.Key} | #{string.Join(", #", tags)}");
            }               
        }
    }

    public static HashSet<string> AddTagsToTheTopic(HashSet<string> tags, HashSet<string> topicsAndTags)
    {
        foreach (var tag in tags)
        {
            topicsAndTags.Add(tag);
        }

        return topicsAndTags;          
    }

    public static HashSet<string> AddAllInputedTags(string[] topicAndTags, HashSet<string> tags)
    {
        for (int i = 2; i < topicAndTags.Length; i++)
        {
            if (topicAndTags[i] != "")
            {
                tags.Add(topicAndTags[i]);
            }
        }

        return tags;
    }

    public static string ReplaceCommaWithSpace(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ',')
            {
                input = input.Replace(',',' ');
                i--;
            }
        }
        return input;
    }
}

