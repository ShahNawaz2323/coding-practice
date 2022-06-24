using System;
using System.Collections.Generic;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //int odd = 0;
            System.Console.WriteLine("ODD Number from 1 to 99");
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) == 0 )
                {
                    continue;
                }
                System.Console.WriteLine(i);
            }
        
        //    System.Console.WriteLine("Write a C# program to find the longest word in a string");
        //    string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
        //    string[] words  = line.Split(new[] {" "}, StringSplitOptions.None);
        //    string word = "";
        //    int ctr = 0;
        //    foreach (string s in words)
        //    {
        //        if(s.Length > ctr)
        //        {
        //            word = s;
        //            ctr = s.Length;
        //        }
               
        //    }
        //    System.Console.WriteLine(word);
           
            // Console.WriteLine("Write a C# program to check if an given integer is within 20 of 100 or 200.");
            // System.Console.Write("\nInput an integer: ");
            // int x = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine(result(x));

            // string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
                   
            // Console.WriteLine(line.ToLower());
            // System.Console.WriteLine(line.ToUpper());
        }

        // public static bool result(int n)
        // {
        //     if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
        //         return true;
        //     return false;
        // }
    }
}
