using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class HTMLContents
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = "";

        string title = "";
        string tags_body = "<body>" + Environment.NewLine;


        while (input != "exit")
        {
            string[] tagAndContent = input.Split(' ');
            string tag = tagAndContent[0];
            string content = tagAndContent[1];

            if (tag == "title")
            {
                title = $"   <title>{content}</title>";
            }

            else
            {
                tags_body += $"    <{tag}>{content}</{tag}>";
                tags_body += Environment.NewLine;
            }

            input = Console.ReadLine();
        }

        result += "<!DOCTYPE html>" + Environment.NewLine;
        result += "<html>" + Environment.NewLine;
        result += "<head>" + Environment.NewLine;
        result += title + Environment.NewLine;
        result += "</head>" + Environment.NewLine;
        result += "<body>" + Environment.NewLine;
        result += tags_body;
        result += "</body>" + Environment.NewLine;
        result += "</html>";
    
        File.WriteAllText("SimpleHTML.html", result);
    }
}

