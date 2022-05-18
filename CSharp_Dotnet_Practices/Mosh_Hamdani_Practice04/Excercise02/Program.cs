using System;
using System.Collections.Generic;

namespace Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Check duplicate Numbers************");

            Console.Write("Enter Numbers Like(1-2-3-4): ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }
            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            var uniques = new List<int>();
            var Duplicates = false;

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
                else
                {
                    Duplicates = true;
                    break;
                }
            }

            if (Duplicates)
                {
                    System.Console.WriteLine("Contains Duplicate.....");
                }
                else
                {
                    System.Console.WriteLine("Not Contains Duplicates.....");
                }
            //var collection = new List<int>();
            System.Console.Write("Input Numbers are: \n" );
            foreach (var number in uniques)
            {
                System.Console.Write(number);
            }
            /*
            System.Console.WriteLine("Given numbers are " + collection);
            collection.ForEach(System.Console.WriteLine(collection<>),collection;);
            */
        }

    }
}
