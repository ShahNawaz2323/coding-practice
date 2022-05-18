using System;
using System.Collections.Generic;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements;
            while(true)
            {
            Console.Write("Enter a List of comma-separated numbers: ");
            var input = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(input))
            {
                elements = input.Split(',');
                if(elements.Length >= 5)
                {
                    break;
                }
            Console.WriteLine("invalid List");
            }
            }
            var numbers = new List<int>();
            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }
            var smallest = new List<int>();
            while (smallest.Count<3)
            {
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if(number < min)
                    {
                        min= number;
                    }
                }
                smallest.Add(min);

                numbers.Remove(min);
            }
            System.Console.WriteLine("the 3 smallest numbers are: ");
            foreach (var number in smallest)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}
