using System;

namespace Excercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************PASCAl Case ******************");
            System.Console.Write("Enter Few Words: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                System.Console.WriteLine("Error");
                return;
            }
            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordPascal = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName = variableName + wordPascal;
            }
            System.Console.WriteLine(variableName);
        }
    }
}
