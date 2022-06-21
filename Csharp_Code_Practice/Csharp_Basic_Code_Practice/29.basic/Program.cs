using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // stringManipulation m = new stringManipulation();
            // m.Method1();
            string str1 = "PHP Tutorial";
            var result = "";

            if (str1.Length >= 1 && str1[0] == 'P')
                result = result + str1[0];
            if (str1.Length >= 2 && str1[1] == 'H')
                result = result + str1[1];

            System.Console.WriteLine(result);            



        }
    }
}
