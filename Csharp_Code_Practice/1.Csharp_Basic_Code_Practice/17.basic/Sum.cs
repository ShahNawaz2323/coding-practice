using System;

namespace basic
{
    public class Sum
    {
        public void TripleSum(int x , int y)
        {
            
            if (x == y)
            {
                int result = (x+y)*3 ;
                //return ((x+y)*3);
                Console.WriteLine(result);
            }
            else
            {
                System.Console.WriteLine("Not Same Integer");
            }
        }
    }
}
