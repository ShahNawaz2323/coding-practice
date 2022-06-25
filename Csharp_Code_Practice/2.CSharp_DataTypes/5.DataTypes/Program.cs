using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****distance and time as input and displays the speed in kilometres per hour and miles per hour.*****");
            float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Input distance(metres): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour): ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Your speed in metres/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);




            // System.Console.Write("Input distance (metres): ");
            // int m = Convert.ToInt32(Console.ReadLine());
            // System.Console.Write("Input Time (Hours): ");
            // int th = Convert.ToInt32(Console.ReadLine());
            // System.Console.Write("Input Time (minutes): ");
            // int tm = Convert.ToInt32(Console.ReadLine());
            // System.Console.Write("Input time (seconds): ");
            // int ts = Convert.ToInt32(Console.ReadLine());

            // int result;
            // result = m/ts;
            // System.Console.Write("Your speed in metres/sec is: " + result);
        }
    }
}
