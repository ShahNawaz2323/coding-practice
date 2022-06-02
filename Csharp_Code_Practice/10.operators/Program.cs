using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************Cschap Operators**************");
            int x = 5 , y = 3;
            System.Console.WriteLine(x+y);
            System.Console.WriteLine(x-y);
            System.Console.WriteLine(x*y);
            System.Console.WriteLine(x/y);
            System.Console.WriteLine(x%y);
            System.Console.WriteLine("Value : {0}",x);
            x++;
            System.Console.WriteLine("after value : {0}",x);

            System.Console.WriteLine("Value : {0}",x);
            x--;
            System.Console.WriteLine("after value : {0}",x);

            System.Console.WriteLine("Value : {0}",x);
            x += 5;
            System.Console.WriteLine("after value : {0}",x);

            System.Console.WriteLine("Value : {0}",x);
            x  -= 5;
            System.Console.WriteLine("after value : {0}",x);



        }
    }
}
