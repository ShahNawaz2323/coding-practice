using System;
using System.Linq;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Write a C# program to count a specified number in a given array of integers");
            System.Console.Write("Input an integer : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] myVar = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            System.Console.WriteLine("Number of " + x + " Present in the array" );
            System.Console.WriteLine(myVar.Count(n => n == x));
            System.Console.WriteLine("Write a C# program to check if a number appears as either the first or last element of an array");
            System.Console.WriteLine((x == myVar[0]) || (myVar[myVar.Length - 1] == x));

            System.Console.WriteLine("Compute the sum of the array......");
            int commute = 0  ;
            // foreach (var item in myVar)
            // {
            //     commute += item;
            // }
            for (int i = 0 ; i < myVar.Length ; i++) { commute += myVar[i]; };
            System.Console.WriteLine(commute);

        }
    }
}
