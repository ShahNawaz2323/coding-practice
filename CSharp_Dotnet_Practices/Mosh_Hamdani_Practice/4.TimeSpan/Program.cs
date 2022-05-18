using System;

namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************Time Span Creating*************");
            var timeSpan = new TimeSpan(1,2,3);
            var timespan1 = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            System.Console.WriteLine("\n\n**********************Time Span Properties*************");
            System.Console.WriteLine("Minutes: " + timeSpan.Minutes);
            System.Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            Console.WriteLine("**********************Time Span Add*************");
            System.Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)) );
            System.Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            Console.WriteLine("\n**********************Time Span ToString()*************");
            System.Console.WriteLine("ToString: " + timeSpan.ToString());
            Console.WriteLine("\n**********************Time Span Parse*************");
            System.Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
