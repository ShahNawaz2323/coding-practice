using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a C# program to rotate an array (length 3) of integers in left direction.");
            int[] nums = {1,2,3};
            int[] result = new int[nums.Length];
            for (int i = 2; i <= 0 ; i--)
            {
                result[i] += nums[i];
            }
            System.Console.WriteLine(result);
            // var temp = nums[0];
            // for (var i = 0; i < nums.Length - 1; i++)
            // {
            //     nums[i] = nums[i + 1];
            // }
            // nums[nums.Length - 1] = temp;
            // Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));

        }
    }
}
