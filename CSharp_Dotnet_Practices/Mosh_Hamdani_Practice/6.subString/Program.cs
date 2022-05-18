using System;
using System.Collections.Generic;

namespace subString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Substring Method to show the summry view*********");
            var sentence = "This is going to be really really really really really really really long text";
            var summry = StringUtility.SummerizeText(sentence);
            System.Console.WriteLine(summry);
        }
        
    }
}