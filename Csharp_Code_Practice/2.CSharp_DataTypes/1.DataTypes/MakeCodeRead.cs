using System;
namespace DataTypes
{
    public class MakeCodeRead
    {
        
        public void Revfunction()
        {
            Console.WriteLine(" Write a C# Sharp program that takes three letters as input and display them in reverse order.");
            System.Console.WriteLine("Give Input abc....to print reverse of it");
            // string[] input = Console.ReadLine();
            // string[] rev = Array.Reverse(input);
            char letter , letter1, letter2;

            System.Console.Write("Input Letter: ");
            letter = Convert.ToChar(Console.ReadLine());

            System.Console.Write("Input Letter1 : ");
            letter1 = Convert.ToChar(Console.ReadLine());

            System.Console.Write("Input Letter2: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            System.Console.WriteLine($"Reverse of the string char: {letter2} {letter1} {letter} \n");
        }
    }
}
