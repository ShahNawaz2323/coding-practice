using System;


namespace Basic
{
    public class multipleLaw
        {
            public void function1()
            {
            int result;
            Console.WriteLine("Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z");
            System.Console.WriteLine("Enter first Number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Enter Second Number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Enter Third Number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            result = x+y+z;
            System.Console.WriteLine("{0}+{1}+{2} = {3}",x,y,z,result);

            result = (x*y) + (y*z);
            System.Console.WriteLine("({0}*{1}) + ({2}*{3}) = {4}",x,y,y,z,result);
            }
            
        }
}
