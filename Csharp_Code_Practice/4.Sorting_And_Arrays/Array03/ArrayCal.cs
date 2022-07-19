using System;
namespace Array03
{
    public class ArrayCal
    {
        public int[] a = new int[100];
        public int i, n, sum = 0;
        public int[] a2 = new int[100];
        public void ArrayQ()
        {
            Console.WriteLine("Write a program in C# Sharp to find the sum of all elements of the array.");

        }

        public void Input()
        {
            System.Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                System.Console.Write("element -{0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void SumOfArr()
        {
            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            System.Console.WriteLine("Sum of all elements stored in the array is: {0}\n\n", sum);
        }

        public void Copy()
        {
            for (i = 0; i < n; i++)
            {
                a2[i] = a[i];
            }
        }

        public void SumOfArr2()
        {
            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            System.Console.WriteLine("Sum of all elements stored in the array2 is: {0}\n\n", sum);
        }

        public void arrayShow()
        {
            Console.Write("\n\nThe elements copied into the second array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a2[i]);
            }
            Console.Write("\n\n");
        }
    }
}

