using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a C# program to get the absolute value of the difference between two given numbers....");
            
            int input1 = result(13,40);
            int input2 = result(50,21);
            int input3 = result(0,23);

            System.Console.WriteLine(input1);
            System.Console.WriteLine(input2);
            System.Console.WriteLine(input3);

            //var input4 = new input();
            // inputed();

            System.Console.Write("Input an integer : ");
            int x = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Input an integer : ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x == 20 || y==20 || (x+y == 20))
            {
                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }
        }
        public static int result(int a , int b)
        {
            if (a > b )
            {
                return (a-b)*2;
            }
            return b - a;
        }
        // public static bool inputed()
        // {
            
        
        // }
    }
}
