using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[ , ] someNums = new int[3,2] { {2,3} , {5,6}, {4,6} };
            //someNums =  { {2,3} , {5,6}, {4,6} };
            
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    System.Console.Write(someNums[k,j] + " " +someNums[k,j]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
