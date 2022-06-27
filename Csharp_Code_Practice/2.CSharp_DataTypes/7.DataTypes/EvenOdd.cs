using System;

namespace DataTypes
{
    public class EvenOdd
    {
        public void evenOdd()
        {
            Console.WriteLine("************Write a C# Sharp program that takes two numbers as input and returns true or false, when both numbers are even or odd.******** ");
            
            int a , b , result1, result2;
            Console.Write("Provide First Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Provide Second Number: ");
            b = Convert.ToInt32(Console.ReadLine());

            result1 = (a % 2);
            result2 = (b % 2);
            if((result1 == 0) && (result2 == 0))
            {
                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }
        }
    }
}
