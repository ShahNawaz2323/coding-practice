using System;
using System.Text;

namespace StringbuidlerPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************String Builder Method");
            var builder = new StringBuilder("Hello World");
            builder
                .Append('-',10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-',10)
                .Replace('-' , '+')
                .Remove(0,10)
                .Insert(0,new string('-', 10));
            System.Console.WriteLine(builder);

            System.Console.WriteLine( "First Char:  "+ builder[0] );
        }
    }
}
