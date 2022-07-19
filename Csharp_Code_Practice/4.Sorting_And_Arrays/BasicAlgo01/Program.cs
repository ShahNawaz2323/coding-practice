using System;

namespace BasicAlgo01
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine(test(30,0));
            // Console.WriteLine(test(25, 5));
            // Console.WriteLine(test(20, 30));
            // Console.WriteLine(test(20, 25));
            // Console.ReadLine();
            Console.WriteLine(test("103"));
            Console.WriteLine(test("90"));
            Console.WriteLine(test("if else"));
            System.Console.WriteLine(test("else"));
            Console.ReadLine();

        }
        public static string test(string s)
        {
            if(s.Length > 2 && s.Substring(0,2).Equals("if"))
            {
                return s;
            }
            else{
                return "if " + s;
            }
        }
        // public static bool test(int x)
        // {
        //       if(Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10)
        //         return true;
        //     return false;
        // }
        // public static bool test(int x, int y)
        // {
        //     return x == 30 || y == 30 || (x + y == 30);
        // }
    }
}
