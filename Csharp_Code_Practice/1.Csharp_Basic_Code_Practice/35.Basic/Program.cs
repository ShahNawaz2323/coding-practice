using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            var result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2  == 0 )
                {
                    result += str[i];
                }
            }
            System.Console.WriteLine(result);
    
        //    System.Console.Write("Input a string:  ");
        //    string str = Console.ReadLine();
        //    if (str.Length < 4)
        //    {
        //     System.Console.WriteLine(str.ToUpper());
        //    }
        //    else
        //    {
        //     System.Console.WriteLine(str.Substring(0,4).ToLower() + str.Substring(4, str.Length -4));
        //    }
        }
    }
}
