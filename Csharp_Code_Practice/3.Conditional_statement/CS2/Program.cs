using System;

namespace CS2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ValueDependent();
            Height height = new Height();
            height.height_finder();
        }
        public static void ValueDependent()
        {
            float m ;
            float n = 1;
            Console.WriteLine("****************************Write and change the value depending on the input**********");
            System.Console.Write("Test Data: ");
            m = Convert.ToInt32(Console.ReadLine());
            if (m > 0)
            {
                System.Console.WriteLine($"The Value of n is : {n}");
            }
            else if(m == 0)
            {
                n = 0 ;
                System.Console.WriteLine($"The Value of n is : {n}");
            }
            else if(m < 0)
            {
                n = -1;
                System.Console.WriteLine($"The Value of n is {n}");
            }
            else
            {
                System.Console.WriteLine("The Given Value of input is Invalid ");
            }
            Console.Write("The value of m = {0} \n",m);
        }
    }
}
