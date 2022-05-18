using System;

namespace MethodPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10,20);
            point.Move(new Point(40,60));
            System.Console.WriteLine("Point is at {0},{1}", point.X, point.Y);
        }
    }
}
