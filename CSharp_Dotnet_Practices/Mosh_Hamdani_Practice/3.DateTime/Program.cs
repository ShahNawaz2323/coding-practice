using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n******************Date And Time Presentation************");

            var datetime = new DateTime(2015,1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            System.Console.WriteLine("Hour: " + now.Hour);
            System.Console.WriteLine("Minute: " + now.Minute);
            System.Console.WriteLine("set time: " + datetime);
            System.Console.WriteLine("Today: " + today);
            
            Console.WriteLine("\n******************Modify Date And Time************");
            //using add function
            var tomrrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            System.Console.WriteLine("Tomorrw: " + tomrrow);
            System.Console.WriteLine("yesterday: " + yesterday);

            Console.WriteLine("\n******************Date And Time Styles************");
            System.Console.WriteLine("Long Date: " + now.ToLongDateString());
            System.Console.WriteLine("Short Date: " + now.ToShortDateString());
            System.Console.WriteLine("Long Time: " + now.ToLongTimeString());
            System.Console.WriteLine("Short Date: " + now.ToShortTimeString());

            Console.WriteLine("\n******************Date And Time ToString()************");
            System.Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));


        }
    }
}
