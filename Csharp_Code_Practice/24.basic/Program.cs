using System;
using System.Collections.Generic;
using System.IO;
namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("*******************Find the size of file ***************");
            FileInfo f = new FileInfo(@"C:\Users\shahn\Downloads\Documents\HEC.pdf");
            string fl = f.Length.ToString();
            int size1 = Convert.ToInt32(fl);
            size1 /= 1024;
            System.Console.WriteLine("\nSize of file is: "+ size1 + " KB");
            
            // string line = "Display the pattern like pyramid using the alphabet.";
            // Console.WriteLine("\nOriginal String: " + line);
            // string result = "";
            // List<string> wordsList = new List<string>();
            // string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

            // for (int i = words.Length - 1; i >= 0; i--)
            // {
            //     result += words[i] + " ";
            // }

            // wordsList.Add(result);
            // foreach (String s in wordsList)
            // {
            //     Console.WriteLine("\nReverse String: " + s);
            // }

            // Console.Write("Input  a number(integer): ");
            // int n = Convert.ToInt32(Console.ReadLine());
            // int sum = 0;

            // while (n != 0)
            // {
            //     sum += n % 10;
            //     n /= 10;
            // }
            // System.Console.WriteLine("Sum of the digits of the said integer: " + sum);


            //testing
            // sum += n % 10;

            // System.Console.WriteLine(sum);
            // n /= 10;
            // System.Console.WriteLine(n);
            // sum = sum + n;
            // System.Console.WriteLine(sum);

            //     Console.WriteLine("\nSum of the first 500 prime numbers: ");
            //        long sum = 0;
            //         int ctr = 0;
            //         int n = 2;
            //         while (ctr < 500)
            //           {
            //             if (isPrime(n))
            //             {
            //                 sum += n;
            //                 ctr++;
            //             }
            //             n++;
            //         }

            //         Console.WriteLine(sum.ToString());            

        }

        //  public static bool isPrime(int n)
        //     {
        //         int x = (int)Math.Floor(Math.Sqrt(n));

        //         if (n == 1) return false;
        //         if (n == 2) return true;

        //         for (int i = 2; i <= x; ++i)
        //         {
        //             if (n % i == 0) return false;
        //         }

        //         return true;
        //     }
    }
}
