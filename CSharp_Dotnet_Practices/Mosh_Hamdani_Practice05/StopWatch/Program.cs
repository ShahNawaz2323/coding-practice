using System;
using System.Diagnostics;
using System.Threading;

namespace StopWatchPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            //Begin timing
            for (int i = 0; i < 10000; i++)
            {
                Thread.Sleep(1);
            }

            //stop timing
            stopwatch.Stop();

            //write result
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

            
        }
    }
}
