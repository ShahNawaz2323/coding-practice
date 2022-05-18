using System;
using System.Collections.Generic;

namespace Excercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n********Check Numbers are seprated by hyphen\"-\" Consecutive or not****** ");

            System.Console.Write("Enter few numbers (like 1-2-3-4):  ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i-1]+1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive? "Consecutive" : "Not-Consectutive";
            System.Console.WriteLine(message);
        }
    }
}
