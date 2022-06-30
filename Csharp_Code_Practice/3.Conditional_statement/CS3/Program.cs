using System;

namespace CS3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Write a C# Sharp program to accept a coordinate point in an XY********");
            System.Console.Write("\n Input the Value for X coordinate: ");
            int X = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("\n Input the Value for Y coordinate: ");
            int Y = Convert.ToInt32(Console.ReadLine());


            // System.Console.WriteLine("The coordinate point ({X} , {Y}) lies in the First quadrant.");
            //First Quardiant
            if (X >= 1 && Y >= 1)
            {
                System.Console.WriteLine($"The coordinate point ({X} , {Y}) lies in the First quadrant.");
            }
            //Second Quardiant
            else if(X < 0 && Y > 0 )
            {
                System.Console.WriteLine($"The coordinate point ({X} , {Y}) lies in the Second quadrant.");
            }
            //Third Quardiant
            else if(X < 0 && Y < 0 )
            {
                System.Console.WriteLine($"The coordinate point ({X} , {Y}) lies in the Third quadrant.");
            }
            //fourth Quardian
            else if(X > 0 && Y < 0 )
            {
                System.Console.WriteLine($"The coordinate point ({X} , {Y}) lies in the Second quadrant.");
            }
            //Origin
            else if(X == 0 && Y == 0 )
            {
                System.Console.WriteLine($"The coordinate point ({X} , {Y}) lies at the origin.");
            }
            else{
                System.Console.WriteLine("The input value is invalid");
            }
        }
    }
}
