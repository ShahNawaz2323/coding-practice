using System;

namespace Basic
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("create a new string from a given string where the first and last characters will change their positions");
            // string txt1 = "w3resource";
            // string txt2 = "Python";

            System.Console.WriteLine(first_last("w3resource"));
            System.Console.WriteLine(first_last("Python"));
            System.Console.WriteLine(first_last("x"));
        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1 ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
}
