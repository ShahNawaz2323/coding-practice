using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing,entered by the user");
            System.Console.Write("Enter First Number: ");
            int x = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter Second Number: ");
            int y = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Operation on the numbers");
            System.Console.WriteLine("{0} + {1} = {2}",x,y, x+y);
            System.Console.WriteLine("{0} + {1} = {2}", x,y, x-y);
            System.Console.WriteLine("{0} + {1} = {2}",x,y, x*y);
            System.Console.WriteLine("{0} + {1} = {2}",x,y, x%y);
            
        }
    }
}
