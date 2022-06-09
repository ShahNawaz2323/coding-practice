using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************Csharp Arrays Practice******************");
            string[] cars = {"volvo" , "BMW", "Ford", "Mazda"};
            System.Console.WriteLine(cars[0]);
            System.Console.WriteLine("change the value by accessing  index");
            cars[0] = "opel";
            System.Console.WriteLine(cars[0]);
            System.Console.WriteLine("************Length of  the array");
            System.Console.WriteLine(cars.Length);

            System.Console.WriteLine("****************Loop through an array************");
            for (int i = 0; i < cars.Length; i++)
            {
                System.Console.WriteLine(cars[i]);
            }
            System.Console.WriteLine("****************Loop through an array with foreach************");
            foreach (string item in cars)
            {
                System.Console.WriteLine(item);
            }
            //Sort a string
            System.Console.WriteLine("****************Sorting of A String Array************");
            Array.Sort(cars);
            foreach (var item in cars)
            {
                System.Console.WriteLine(item);
            }

            //sort an int
            System.Console.WriteLine("****************Sorting of An Integer Array************");
            int[] myNumbers = {1,2,5,2,6,2,6,4,3,7,7,9,5,10};
            Array.Sort(myNumbers);
            foreach (var item in myNumbers)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("**********Find the Largest, smallest value, myNumbers****");
            System.Console.WriteLine(myNumbers.Max());
            System.Console.WriteLine(myNumbers.Min());
            System.Console.WriteLine(myNumbers.Sum());
        }
    }
}
