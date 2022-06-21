using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.");
            // kelvin = celsius + 273
            // fahrenheit = celsius x 18 / 10 + 32
            int k = 273;
            int f = 1;

            System.Console.Write("Tell temperature in Celsius to calculate : ");
            int v1 = Convert.ToInt32(Console.ReadLine());

            int result1 = v1+k;
            System.Console.WriteLine("Kelvin is : {0}",result1);

            f = v1*18/10+32;
            System.Console.WriteLine("Fahrenheit is: {0}",f);
        }
    }
}
