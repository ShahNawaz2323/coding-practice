using System;

namespace ExceptionPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************Csharp Exception and try catch block*********************\n");
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}