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
            string html = string.Empty;
            string url = "http://www.mso.anu.edu.au/~ralph/OPTED/v003/wb1913_" + FirstLetter + ".html";

            //HttpWebRequest request = (HttpWebRequest) 

            TypeLine(url);
        }

        

        static void TypeLine(string line)
        {
            foreach (char c in line)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
        }
    }
    

    public enum WordType { Noun, Verb, Pronoun, Adjective, Abverb, Preposition, Conjunctation, Interjection }
}

