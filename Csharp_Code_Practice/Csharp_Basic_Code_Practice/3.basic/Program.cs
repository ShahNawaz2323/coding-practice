using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Write a C# Sharp program to swap two numbers");
            // int x = 5, y = 6;
            // int swap;

            // swap = y;
            // y = x;
            // x = swap;

            // System.Console.WriteLine("Swap x and y values: ");
            // System.Console.WriteLine("First Number: "+x);
            // System.Console.WriteLine("Second Number: "+y);

            int x , y , z;
            System.Console.WriteLine("output of multiplication of three numbers which will be entered by the user.");
            
            System.Console.WriteLine("Enter first Number: ");
            x = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter first Number: ");
            y= Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter first Number: ");
            z = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Multiplication of three numbers: "+ x*y*z);
            System.Console.WriteLine("Input Numbers are {0} x {1} x {2}", x,y,z);
        }
    }
}