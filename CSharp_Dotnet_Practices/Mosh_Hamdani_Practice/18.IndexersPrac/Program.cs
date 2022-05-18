using System;

namespace IndexersPrac
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var cookie =new HttpCookie();
            cookie["name"] = "Mosh";
            System.Console.WriteLine(cookie["name"]);
        }
    }
}
