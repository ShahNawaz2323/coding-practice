using System;
using System.Collections.Generic;

namespace ListPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var numbers = new List<int>() {1,2,3,4};
            numbers.Add(1);
            numbers.AddRange(new int[3] {5,6,7} );

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            } 
            System.Console.WriteLine();
            System.Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            System.Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));
            System.Console.WriteLine("Count: " + numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            } 

            System.Console.Write("Clearning the list---"); 
            numbers.Clear();
            System.Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
