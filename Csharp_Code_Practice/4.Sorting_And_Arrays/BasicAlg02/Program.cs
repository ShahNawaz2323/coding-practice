using System;

namespace BasicAlg02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Write a C# Sharp program to remove the character in a given position of a given string****");
            System.Console.WriteLine(test("Python",1));
            Console.WriteLine(test("Python", 0));
            Console.WriteLine(test("Python", 4));
            Console.ReadLine();
        }

        //  public static string test(string str, int n)
        // {
        //     return str.Remove(n, 1);
        // }
        public static string test(string str, int n)
        {
            if (str.Length >= 2)
            {
                return str.Remove(n,1);
            }
            else
            {
                return "string is to small";
            }

        }
    }
}
