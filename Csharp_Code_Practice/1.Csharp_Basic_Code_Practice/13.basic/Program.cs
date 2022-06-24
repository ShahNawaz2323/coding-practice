using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************String Maniplution**************");
            // //string txt = "w3resource";
            // // System.Console.WriteLine(remove_char("w3resource", 1));
            // // System.Console.WriteLine(remove_char("w3resource", 9));
            // // System.Console.WriteLine(remove_char("w3resource", 0));

            // // static string remove_char(string str, int n)
            // // {
            // //     return str.Remove(n,1);
            // // }

            // string txt = "w3resource";
            // System.Console.WriteLine("w3resource");
            // string txt2 = txt.Replace("3","");
            // System.Console.WriteLine(txt2);
            // string txt3 = txt.Replace("r","");
            // System.Console.WriteLine(txt2);
            // string txt4 = txt.Replace("w","");
            // System.Console.WriteLine(txt4);
            
            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));     
        
            
        }
            public static string remove_char(string str, int n)
            {
            return str.Remove(n, 1);
            }
    }
}
