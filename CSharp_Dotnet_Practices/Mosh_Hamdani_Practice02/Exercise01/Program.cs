using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please Enter A Number: ");
            var input = Convert.ToInt32(Console.ReadLine());

            if ( input <= 10 && input >= 1)
            {
                System.Console.WriteLine("Number is Valid.");
            }
            else
            {
                System.Console.WriteLine("input: {0} is invalid", input);
            }
        }
    }
}
