using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS8
{
    public class GradeFinder
    {
        public void Grade()
        {
            // string notes;
            char grd;
            Console.Write("\n\n");
            Console.Write("Accept a grade and display equivalent description:\n");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            System.Console.Write("Input The Grade: ");
            grd = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grd)
            {
                case 'E':
                    System.Console.WriteLine("Excellent");
                    break;
                case 'V':
                    System.Console.WriteLine("Very Good");
                    break;
                case 'G':
                    System.Console.WriteLine("Good");
                    break;
                case 'A':
                    System.Console.WriteLine("Average");
                    break;
                case 'F':
                    System.Console.WriteLine("Fail");
                    break;
                default:
                    System.Console.WriteLine("Not found the grade match");
                    break;
            }

        }
    }
}
