using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum;
            myNum = 15;
            string name = "shah";
            Console.WriteLine(name);
            Console.WriteLine(myNum);
            myNum = 20;
            System.Console.WriteLine(myNum);
            System.Console.WriteLine("Hello " + name);
            string name2 = "nawaz";
            System.Console.WriteLine(name + name2);

            var fullname = name + name2;
            System.Console.WriteLine(fullname);

            int x = 5, y= 7, z=50;
            System.Console.WriteLine(x + y + z);

        }
    }
}
