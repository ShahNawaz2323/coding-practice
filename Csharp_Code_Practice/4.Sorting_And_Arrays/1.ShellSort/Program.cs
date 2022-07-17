using System;

namespace _1.ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int n;
            n = arr.Length;

            //Original Array display
            System.Console.WriteLine("Original Array Elements : ");
            show_array_elements(arr);

            //Sorthing the Array
            shellSort(arr, n);
            //Sorted Array Display
            System.Console.WriteLine("\nSorted Array Elements :");
            show_array_elements(arr);
        }
        public static void shellSort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }
        public static void show_array_elements(int[] arr)
        {
            foreach (var element in arr)
            {
                System.Console.Write(element + " ");
            }
            System.Console.Write("\n");
        }
    }
}
