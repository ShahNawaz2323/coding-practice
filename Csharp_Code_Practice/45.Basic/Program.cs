using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Write a C# program to find the pair of adjacent elements that has the largest product of \n************an given array which is equal to a given value.*****");
            System.Console.WriteLine("\n");
            Console.WriteLine(array_adjacent_elements_product(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 0, -1,-1, -2 }) == 2);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 1, 4, 3, 0 }) == 16);
        }

        public static int array_adjacent_elements_product(int[] input_array)
        {
            int array_index = 0 ;
            int product = input_array[array_index] * input_array[array_index + 1] ;
            array_index++;
            while (array_index + 1 < input_array.Length)
            {
                product = ((input_array[array_index] * input_array[array_index + 1]) > product) ?
                        (input_array[array_index] * input_array[array_index + 1]) :
                        product;
                array_index++;
            }
            return product;
        }
    }
}
