using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input 2 numbers to Compare: ");
            
            System.Console.Write("Number 1: ");
            var input1 = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Number 2: ");
            var input2 = Convert.ToInt32(System.Console.ReadLine());

            if (input1 > input2)
            {
                System.Console.WriteLine("{0} is bigger than {1}", input1, input2);
                System.Console.WriteLine("First if running");
            }
            else if (input1 < input2)
            {
                System.Console.WriteLine("{0} is bigger than {1}", input2, input1);
                System.Console.WriteLine("else if running");
            }
            else
            {
                System.Console.WriteLine("Comparison is not possible");
                System.Console.WriteLine("else running");
            }
        }
    }
}
