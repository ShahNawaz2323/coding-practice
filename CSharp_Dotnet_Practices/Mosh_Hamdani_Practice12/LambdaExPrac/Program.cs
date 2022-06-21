using System;
using System.Collections.Generic;

namespace LambdaExPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //args => expression
            // number => number*number
            // Func<int,int> square = number => number*number; 

            // Func<int,int> square = number=> number*number;
            // System.Console.WriteLine(square(5));
            const int factor = 5;
            Func<int, int> multiplyer = n => n*factor;
            var result = multiplyer(10);
            System.Console.WriteLine(result);

        //     const int factor = 5;
        //    Func<int,int> multipler = n => n*factor;
        //    var result = multipler(10);
        //    System.Console.WriteLine(result);
            //() => ....
            //x =>...
            // (x,y,z) => ...
         }

        // static int  square(int number)
        // {
        //     return number*number;
        // }
    }
}
