using System;

namespace IfElsePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************IF ELSE Statement****************");
            if (20>18)
            {
                System.Console.WriteLine("20 is greater than 18");
            }

            int time = 20;
            if (time < 10)
            {
                System.Console.WriteLine("Good Morning.");
            }
            else if (time < 18)
            {
                System.Console.WriteLine("Good Day.");
            }
            else
            {
                System.Console.WriteLine("Good Evening");
            }
        }
    }
}
