using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if(speedLimit > carSpeed)
            {
                System.Console.WriteLine("Ok");
            }
            else
            {
                const int km_5_demrit_Point = 5;
                var demeritPoints = (carSpeed - speedLimit)/km_5_demrit_Point;

                if (demeritPoints > 12)
                {
                    System.Console.WriteLine("License Suspended");
                    System.Console.WriteLine("Demerit Points:  "+demeritPoints);
                }
                else
                {
                    System.Console.WriteLine("***************************Warning****************************");
                    if (demeritPoints == 12)
                    {
                        System.Console.WriteLine("License Suspension warning 01, Be Careful Next Time ");
                    }

                    System.Console.WriteLine("fine according to the Point: {0}",demeritPoints);
                }
            }
        }
    }
}
