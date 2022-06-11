using System;

namespace InterfacesPloy
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************Interface and Polymorphism*************");
            var encoder = new VideoEncoder();
            encoder.Encode(new video());
        }
    }
}
