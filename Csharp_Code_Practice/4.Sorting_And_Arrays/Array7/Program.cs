using System;

namespace Array7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int n,i,ctr, freq ;
            System.Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            for(i = 0 ; i < n ; i++)
            {
                System.Console.Write("element- {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            ctr = 0;
/***********Frequency occurance*********************/
            if( arr1[0] == arr1[1])
            {
                ctr++;
                if(arr1[1] == arr1[2])
                {
                    ctr += 2;
                }
                System.Console.WriteLine("{0} occurs {1} time.",arr1[0],ctr);
            }
            else if(arr1[1] == arr1[2])
            {
                ctr += 2;
                System.Console.WriteLine("{0} occurs {1} time.",arr1[1],ctr);
            }
            
            else if( arr1[0] != arr1[1] && arr1[1] != arr1[2])
            {
                ctr++;
                System.Console.WriteLine("{0} occurs {1} time.",arr1[0],ctr);
                System.Console.WriteLine("{0} occurs {1} time.",arr1[1],ctr);
                System.Console.WriteLine("{0} occurs {1} time.",arr1[2],ctr);
            }



        }
    }
}
