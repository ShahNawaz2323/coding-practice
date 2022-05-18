using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a Number to get Factorial! : ");
            var input = Convert.ToInt32(Console.ReadLine());

           var factorial = 1;

           for (var i = 1; i <= input; i++)
           {
               factorial *= i;
           }

           System.Console.WriteLine("{0} : factorial is : {1}", input, factorial);
           
           
           
            // var factorialOf = input;

            // for (var i = 1; i <= input; i++)
            // {
            //     input *= i;
            // }
            // System.Console.WriteLine("{0} factorial of {1}", factorialOf , input);

        }
    }
}
