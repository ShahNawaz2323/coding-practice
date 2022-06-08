using System;

namespace CsharpLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************Csharp Loops Practice********************");
            string[] cars = {"Volvo" , "BMW", "Ford", "Mazda"};

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                System.Console.WriteLine(i);
            }


            // for (int i = 0; i < 10; i++)
            // {
            //     if (i == 4)
            //     {
            //         break;
            //     }
            //     System.Console.WriteLine(i);
            // }
            
            // foreach (var item in cars)
            // {
            //     System.Console.WriteLine(item);
            // }

            //int i = 0;
            // while (i < 5 )
            // {
            //     System.Console.WriteLine(i);
            //     i++;
            // }
            // do
            // {
            //     System.Console.WriteLine(i);
            //     i++;
            // } while (i < 5);

            // for (int n = 0; n < 5; n++)
            // {
            //     System.Console.WriteLine(n);
            // }
        }
    }
}
