using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************User Inputs");
            System.Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();

            System.Console.WriteLine("User Name is : " + name);

            System.Console.WriteLine("Enter Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("User Age : " + age);

            System.Console.WriteLine("User Name: {0} ,and age is: {1}", name,age);

        }
    }
}
