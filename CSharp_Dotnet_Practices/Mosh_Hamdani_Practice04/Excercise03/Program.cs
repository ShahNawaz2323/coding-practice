using System;

namespace Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Time Verification***********************");
            System.Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                System.Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                System.Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                {
                    System.Console.WriteLine("Ok");
                }
                else
                {
                    System.Console.WriteLine("Invalid Time");
                }

            }
            catch (System.Exception)
            {
                
                System.Console.WriteLine("Invalid Time");
            }
        }
    }
}
