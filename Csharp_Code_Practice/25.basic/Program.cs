using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Write a C# program to convert a hexadecimal number to decimal number.");
            
            // System.Console.Write("Provide Hexadecimal Values: ");
            // string hexval = Console.ReadLine();
            // System.Console.WriteLine("HexaDecimal Number :" + hexval);
            //// int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            // System.Console.WriteLine("Convert to-");
            // System.Console.WriteLine("Decimal number: " + decValue);

            System.Console.WriteLine("Write a C# program to multiply corresponding elements of two arrays of integers.");
            ArrayMultiply arr = new ArrayMultiply();
            int[] first_array = {1,3,-5,4};
            int[] Second_array = {1,4,-5,-2};
            arr.ArrayMulti(first_array,Second_array);
        }
    }
}
