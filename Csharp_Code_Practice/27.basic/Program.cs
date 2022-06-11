using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
           string str;
           System.Console.WriteLine("Input a string : ");
           str = Console.ReadLine();
           System.Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
        }
    }
}
