using System;

namespace SoloPrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //function for recursive methods to calculate factorial.
            static int Fact(int num)
            {
                if (num == 1)
                {
                    return 1;
                }
                return num * Fact(num-1);
            }
            System.Console.Write("Give Number To Calculate Factorial! : ");
            var input = Convert.ToInt32(Console.ReadLine());
             
            System.Console.WriteLine(Fact(input));
        }
    }
}
