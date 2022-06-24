using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Find The Multiples of given numbers");

            System.Console.Write("Give Number which you want to find multiple: ");
            int v = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int z;
                z = v;
                z = v*i; 
                System.Console.WriteLine("{0} * {1} = {2}",v,i,z);
            }

            System.Console.WriteLine("Write a C# Sharp program that takes four numbers as input to calculate and print the average.");
                int x =10 , y = 15 ,j = 20 , a = 30;
                int u = 4;
                int result = (x+y+j+a)/u;
                System.Console.WriteLine("the average of {0},{1},{2},{3} is : {4}",x,y,j,a,result);
        }
    }
}
