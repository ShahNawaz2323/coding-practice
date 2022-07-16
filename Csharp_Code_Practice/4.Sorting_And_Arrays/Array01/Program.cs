using System;

namespace Array01
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = new int[10];
           int i;
           Console.Write("\n\nRead and Print elements of an array:\n");
           Console.Write("-----------------------------------------\n");
           Console.Write("Input 10 elements in the array :\n");
           for(i = 0; i < 10; i++)
           {
            System.Console.Write("element -{0} : ",i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
           }

           System.Console.Write("\nElements in array here: ");
           for(i = 0 ; i < 10; i++)
           {
            System.Console.Write("{0} ", arr[i]);
           }
           System.Console.Write("\n");

           
        }
    }
}
