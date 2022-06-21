using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // MakeCodeRead rev1 = new MakeCodeRead();
            // rev1.Revfunction();

            // Triangle();
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }

            // public static void Triangle()
            // {
            //     Console.Write("Input a number: ");
            //     int num = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Input the desired width: ");
            //     int width = Convert.ToInt32(Console.ReadLine());

            //     int height = width;
            //     for (int row = 0; row < height; row++)
            //     {
            //         for(int column = 0; column < width; column ++)
            //         {
            //             System.Console.WriteLine(num);
            //         }

            //         System.Console.WriteLine();
            //         width--;
            //     }
            // }
        }
    }
}
