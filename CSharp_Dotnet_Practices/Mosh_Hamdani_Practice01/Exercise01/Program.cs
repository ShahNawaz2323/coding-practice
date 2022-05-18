using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    System.Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
