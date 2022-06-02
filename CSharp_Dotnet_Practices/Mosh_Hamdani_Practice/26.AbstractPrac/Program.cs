using System;

namespace AbstractPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Abstract Classes Practicce**********");
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
