using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.");
            int[] Array1 = {1, 2, 5};
            int[] Array2 = {0, 3, 8};
            int[] Array3 = {-1, 0, 2};

            int num1 = Array1[1];
            int num2 = Array2[1];
            int num3 = Array3[1];

            System.Console.WriteLine("{0} {1} {2} ",num1,num2,num3);
        }
    }
}
