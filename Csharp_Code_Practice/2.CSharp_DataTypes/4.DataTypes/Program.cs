using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            Console.WriteLine("*****Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5).*****");
            System.Console.WriteLine("\n\t\t x = y² - 2y +1");
            System.Console.WriteLine();

            for (y=-5; y <= 5; y++)
            {
                x = y*y - 2*y +1;
                System.Console.WriteLine( "y = {0}; x=({0}² -2*({0}) +1 = {1})",y,x);
            }
        }

    }
}
