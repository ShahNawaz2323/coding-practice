using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a C# program to check two given integers and return true if one is negative and one is positive.");
            int z , e;
            System.Console.Write("Enter First Integer: ");
            z = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter Second Integer: ");
            e = Convert.ToInt32(Console.ReadLine());

            //System.Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0 ));
            // if (x < 0 && y >0 || x > 0 && y < 0 )
            // {
            //     System.Console.WriteLine(true);
            // }
            // else
            // {
            //     System.Console.WriteLine(false);
            // }

            var sum = new Sum();
            sum.TripleSum(z,e);
        }
    }
}
