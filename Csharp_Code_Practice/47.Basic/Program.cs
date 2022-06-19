using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Write a C# program to find the pair of adjacent elements that has the highest \n*******product of an given array of integers. ");
            System.Console.WriteLine("\n");
            Console.WriteLine(adjacent_Elements_Product(new int[] {1, -3, 4, -5, 1}));
            Console.WriteLine(adjacent_Elements_Product(new int[] {1 , 3, 4, 5, 2}));
            Console.WriteLine(adjacent_Elements_Product(new int[] {1 , 3, -4, 5, 2}));
            Console.WriteLine(adjacent_Elements_Product(new int[] {1 , 0, -4, 0, 2}));
        }
        public static int adjacent_Elements_Product(int[] input_Array)
        {
            int max = input_Array[0] * input_Array[1];
            for (int x = 1; x <= input_Array.Length - 2; x++)
            {
                max = Math.Max(max, input_Array[x] * input_Array[x + 1]);
            }
            return max;
        }
    }
}
