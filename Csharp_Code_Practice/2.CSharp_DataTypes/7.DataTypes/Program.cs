using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            string result;
            System.Console.Write("Give DEcimal number input : ");
            answer = Console.ReadLine();
            // BinConversion(bin);
            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int reminder = num % 2;
                result = Convert.ToString(reminder) + result;
                num = num/2;
            }
            result = Convert.ToString(num) + result;
            System.Console.WriteLine("Binary : {0}", result);
        }
        // public static void BinConversion(int dec)
        // {
        //     int a = 2;
        //     int reminder = dec % a;
        //     int reamin = dec / a ;
        //     // do
        //     // {
        //     //     System.Console.Write(reminder);
        //     // }
        //     // while(reamin != 0 || reamin != 1);
            
        // }
    }
}
