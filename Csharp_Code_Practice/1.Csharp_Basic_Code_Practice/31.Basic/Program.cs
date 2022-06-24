using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string (contains at least one 'w' char) : ");
            string str = Console.ReadLine();
            var count = str.Count(s => s == 'w');
            Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
            Console.WriteLine(count >= 1 && count <= 3);

            // Console.Write("Input a string (contains at least one 'w' char) : ");
            // string str = Console.ReadLine();
            // var count = str.Count(s => s == 'w');
            // System.Console.WriteLine("Testing the string contains w characters between 1 and tree times");

            System.Console.WriteLine(count >= 1 && count <= 3);
            // System.Console.WriteLine("Write a C# program to check if a given string contains /‘w/’ character");
            // System.Console.Write("Please Input a string which contains latter w");
            // string input = Console.ReadLine();
            // if (input.Contains("w"))
            // {
            //     System.Console.WriteLine(true);
            // }

            // Console.WriteLine("\nInput first integer:");
            // int x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Input second integer:");
            // int y = Convert.ToInt32(Console.ReadLine());
            // int n = 20;

            // var val1 = Math.Abs(x-n);
            // var val2 = Math.Abs(y-n);
            // System.Console.WriteLine(val1 == val2 ? 0 : val1 < val2 ? x : y);
        }
    }
}
