using System;

namespace ArrayPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("............Arrays Practices........");
            var numbers = new[] {3,7,9,2,14,6};

            System.Console.WriteLine("*****************Original Array**********************");
            foreach (var n in numbers)
            {
                System.Console.Write(n);
            }

            //Length
            Console.WriteLine("\nLength: " + numbers.Length);

            //indexof()
            var index = Array.IndexOf(numbers,9);
            Console.WriteLine("Index of 9 is " + index +".");

            //Clear()
            Array.Clear(numbers,0, 2);


            //After Clearning first 2 elements
            System.Console.WriteLine("**************After Clear the Array*****************");
            foreach (var n in numbers)
            {
                System.Console.Write(n);
            }

             int[] another = new int[3];
             Array.Copy(numbers, another,3);
             System.Console.WriteLine("\n**************Effect of Copy()*****************");
            foreach (var n in another)
            {
                System.Console.Write(n);
            }
            //Sort()
            Array.Sort(numbers);
            System.Console.WriteLine("\n**************Effect of Sort()*****************");
            foreach (var n in numbers)
            {
                System.Console.Write(n);
            }

            Array.Reverse(numbers);
            System.Console.WriteLine("\n**************Effect of Reverse()*************");
            foreach (var n in numbers)
            {
                System.Console.Write(n);
            }
        }
    }
}