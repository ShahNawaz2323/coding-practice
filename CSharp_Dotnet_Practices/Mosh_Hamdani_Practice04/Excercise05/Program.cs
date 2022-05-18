using System;
using System.Collections.Generic;

namespace Excercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Vowels**************");
            System.Console.Write("Enter a Word: ");
            var input = Console.ReadLine().ToLower();

            var Vowels = new List<char>(new char[] {'a','e','o','u','i'});
            var vowlesCount = 0;
            foreach (var character in input)
            {
                if (Vowels.Contains(character))
                {
                    vowlesCount++;
                }
            }
            System.Console.WriteLine(vowlesCount);
        }
    }
}
