using System;

namespace CS1
{
    class Program
    {
        static void Main(string[] args)
        {
            // EvenOdd();
            LeapYear();
        }
        public static void LeapYear()
        {
            int Chk_year;
            System.Console.Write("Provide year to check it leap or not..:");
            Chk_year = Convert.ToInt32(Console.ReadLine());
            if ((Chk_year % 400 ) ==  0)
            {
                System.Console.WriteLine($"{Chk_year} is a leap year");
            }
            else if((Chk_year % 100) == 0)
            {
                System.Console.WriteLine($"{Chk_year} is a leap year");
            }
            else if((Chk_year % 4) == 0)
            {
                System.Console.WriteLine($"{Chk_year} is a leap year");
            }
            else
            {
                System.Console.WriteLine("{0} is not a leap year. \n",Chk_year);
            }
        }
        public static void EvenOdd()
        {
            Console.WriteLine("*****Write a C# Sharp program to check whether a given number is even or odd.*****");
            int input ;
            System.Console.Write("Give Number to Check Even OR ODD: ");
            input = Convert.ToInt32(Console.ReadLine());

            if ( input % 2 == 0 )
            {
                System.Console.WriteLine("Given Number is even integer. ");
            }
            else
            {
                System.Console.WriteLine("Given Number is odd integer.\n......  ");
            }

            if(input >= 0)
            {
                System.Console.WriteLine($"{input} is positive number");
            }
            else
            {
                System.Console.WriteLine($"{input} is Negative number");
            }
        }
    }
}