using System;
using System.Collections.Generic;
namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a numbers: ");
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                System.Console.Write("Please Enter a Number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    System.Console.WriteLine("You've previously entered " + number);
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }

        }
    }
}
