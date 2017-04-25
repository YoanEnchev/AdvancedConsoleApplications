using System;
using System.Collections.Generic;
using System.Linq;

class SocialMediaPosts
{
    static void Main()
    {
        string input = Console.ReadLine();
        var data = new Dictionary<string, Dictionary<int[], string>>();//[] for likes and dislikes

        while (input != "drop the media")
        {
            string[] commandAndToken = input.Split(' ');
            string command = commandAndToken[0];
            string token = GetTheOtherPartFromInput(commandAndToken);

            if (command == "post")
            {
                data = CreatePost(data, token);
            }

            if (command == "like")
            {
                data = AddLike(data, token);
            }

            if (command == "dislike")
            {
                data = AddDisLike(data, token);
            }

            if (command == "comment")
            {
                data = AddComment(data, token);
            }

            input = Console.ReadLine();
        }

        PrintData(data);
    }

    public static void PrintData(Dictionary<string, Dictionary<int[], string>> data)
    {
        foreach (var kvp in data)
        {
            int like = 0;
            int dislike = 0;
            string comments = "";

            Console.Write($"Post: {kvp.Key} | ");
            var LikesDislikesAndComments = data[kvp.Key];

            foreach (var likeDislikeAndComment in LikesDislikesAndComments)
            {
                int[] GetlikesAndDislikes = new int[2];
                GetlikesAndDislikes = likeDislikeAndComment.Key;
                like = GetlikesAndDislikes[0];
                dislike = GetlikesAndDislikes[1];
                comments = likeDislikeAndComment.Value;
            }

            Console.WriteLine($"Likes: {like} | Dislikes: {dislike}");
            Console.WriteLine("Comments:");
            if (comments != "")
            {
                Console.Write(comments);
            }

            else
            {
                Console.WriteLine("None");
            }
        }
    }

    public static Dictionary<string, Dictionary<int[], string>> AddComment(Dictionary<string, Dictionary<int[], string>> data, string token)
    {
        string[] topicNameCommenterContent = token.Split(' '); // comment like hello ,sir
        string topic = topicNameCommenterContent[0];
        string commenter = topicNameCommenterContent[1];
        string content = "";

        for (int i = 2; i < topicNameCommenterContent.Length; i++)
        {
            content += topicNameCommenterContent[i] + " ";
        }

        var LikesDislikesAndComments = data[topic];
        int[] GetlikesAndDislikes = new int[2];

        foreach (var kvp in LikesDislikesAndComments)
        {
            GetlikesAndDislikes = kvp.Key;
        }

        data[topic][GetlikesAndDislikes] += "*  " + commenter + ": " + content + Environment.NewLine; ;

        return data;
    }

    private static Dictionary<string, Dictionary<int[], string>> AddDisLike(Dictionary<string, Dictionary<int[], string>> data, string token)
    {
        string[] commandAndPostName = token.Split(' ');
        string postName = commandAndPostName[0];

        var LikesDislikesAndComments = data[postName];

        foreach (var kvp in LikesDislikesAndComments)
        {
            int[] GetlikesAndDislikes = new int[2];
            GetlikesAndDislikes = kvp.Key;
            GetlikesAndDislikes[1]++; // +1 dislike
        }

        return data;
    }

    public static Dictionary<string, Dictionary<int[], string>> AddLike(Dictionary<string, Dictionary<int[], string>> data, string token)
    {
        string[] commandAndPostName = token.Split(' ');
        string postName = commandAndPostName[0];

        var LikesDislikesAndComments = data[postName];

        foreach (var kvp in LikesDislikesAndComments)
        {
            int[] GetlikesAndDislikes = new int[2];
            GetlikesAndDislikes = kvp.Key;
            GetlikesAndDislikes[0]++; // +1 like
        }

        return data;
    }

    public static Dictionary<string, Dictionary<int[], string>> CreatePost(Dictionary<string, Dictionary<int[], string>> data, string token)
    {
        string[] commandAndPostName = token.Split(' ');
        string postName = commandAndPostName[0];

        int[] likesAndDislikes = new int[2];
        likesAndDislikes[0] = 0; //like
        likesAndDislikes[1] = 0; //dislike

        if (!data.ContainsKey(postName))
        {
            data[postName] = new Dictionary<int[], string>();
            data[postName].Add(likesAndDislikes, "");
        }

        data[postName][likesAndDislikes] = "";

        return data;
    }

    public static string GetTheOtherPartFromInput(string[] commandAndToken)
    {
        string token = string.Empty;

        for (int i = 1; i < commandAndToken.Length; i++)
        {
            token += commandAndToken[i] + " ";
        }

        return token;
    }
}