using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name: ");
            var name = Console.ReadLine();

            //New Array Delaring to save Name 
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                //Name sort in reversed by index and save in new variable "array".
                array[name.Length -i] = name[i-1];
            }
            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }
    }
}
