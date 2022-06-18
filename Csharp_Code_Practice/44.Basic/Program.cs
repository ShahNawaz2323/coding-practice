using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Write a C# program to check if an array contains an odd number.");
            int[] arr = { 2, 4, 7, 8, 6 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    System.Console.WriteLine(true);
                }
                // else
                // {
                //     System.Console.WriteLine("There is no odd number in the array.");
                // }
            }
        }
    }
}
