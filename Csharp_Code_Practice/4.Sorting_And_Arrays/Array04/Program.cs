using System;

namespace Array04
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Write a program in C# Sharp to count a total number of duplicate elements in an array.");
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            int input , inputNumbers, m = 0; 

            System.Console.Write("Input the number of elements in the array : ");
            input = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < input; i++)
            {
                System.Console.Write("element-{0}: ",i);
                inputNumbers = Convert.ToInt32(Console.ReadLine());
                arr1[i] = inputNumbers ;
            }            
            System.Console.Write("\n\n");
            /*-------------------------- Copy in other array -------------- */
            for (int i = 0; i < input; i++)
            {
                arr2[i] = arr1[i];
                // arr3[i] = 0;
            }
            /*-------------------------- Mark the elements are duplicate -------------- */
            foreach(var item in arr2)
            {
                for(int j = 0; j < input; j++)
                {
                    if(item == arr2[j])
                    {
                        arr3[j] = arr2[j];
                        m += 1;
                    }
                    else{
                        continue;
                    }
                }
            }
            /*---------Prints the array -----------------------------*/
            System.Console.WriteLine("The number of duplicate Elements :{0}",m);
            System.Console.Write("dublicate elements in array are : ");
            foreach(var item in arr3)
            {
                System.Console.Write(item);
            }

        }
    }
}
