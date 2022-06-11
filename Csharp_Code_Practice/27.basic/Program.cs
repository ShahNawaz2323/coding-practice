using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string str;
        //    System.Console.WriteLine("Input a string : ");
        //    str = Console.ReadLine();
        //    System.Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
        int x , y ;
        System.Console.Write("Enter first integer : ");
        x = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter second integer : ");
        y = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine((x < 100 && y > 200));
        }
    }
}
