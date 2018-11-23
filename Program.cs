using Microsoft.ML;
using Microsoft.ML.Runtime.Api;
using Microsoft.ML.Runtime.Data;
using Microsoft.ML.Runtime.Learners;
using Microsoft.ML.Transforms.Conversions;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.Threading;
using NetSpell;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace AEGIS
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            GetDefinition(input);

            Console.ReadLine();
        }
        
        static void GetDefinition(string Word)
        {
            char FirstLetter = Word[0];
            string url = "http://www.mso.anu.edu.au/~ralph/OPTED/v003/wb1913_" + FirstLetter + ".html";

            WebClient client = new WebClient();
            Stream stream = client.OpenRead(url);
            StreamReader reader = new StreamReader(stream);
            String content = StripHTML(reader.ReadToEnd());



        
            Console.WriteLine(content);
        }

        static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }



        static void TypeLine(object obj)
        {
            var item = obj.ToString();
            foreach (char c in item)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
        }
    }
}

