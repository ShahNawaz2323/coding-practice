using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Comma Sperated Number: ");
            var input = System.Console.ReadLine();

            var numbers = input.Split(',');

            //Assume the first number is the max
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max )
                {
                    max = number;
                }
            }
            System.Console.WriteLine("Max is: " + max);


        }
    }
}
