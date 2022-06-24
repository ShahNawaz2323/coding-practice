using System;

namespace typeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Implicit Conversion*************");
            int i = 9;
            double d = i; //automatic or  implicit conversion

            System.Console.WriteLine(i);
            System.Console.WriteLine(d);

            Console.WriteLine("***************explicit Conversion*************");
            double d2 = 9.78;
            int myInt = (int)d2; //Manual casting or  explicit casting
            System.Console.WriteLine(d2);
            System.Console.WriteLine(myInt);

            Console.WriteLine("***************Type Conversion Methods*************");
            int myInt1 = 10;
            int myDouble1 = (int)4.55;
            bool myBool = true;
            System.Console.WriteLine(Convert.ToString(myInt1)); //convert int to string
            System.Console.WriteLine(Convert.ToDouble(myInt1)); //Convert int to double
            System.Console.WriteLine(Convert.ToInt32(myDouble1)); //convert double to int
            System.Console.WriteLine(Convert.ToSingle(myBool)); //Convert bool to string


        }
    }
}
