using System;
namespace DataTypes
{
    class Program
    {

        static void Main(string[] args)
        {
            //call the redius function by object
            radius rad = new radius();
            rad.radiusCal();

            //vowel finder
            vowel();
        }
        static void vowel()
        {
            char symbol;

            System.Console.Write("Input a symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
            {
                System.Console.WriteLine("It's a lowercase vowel.");
            }
            else if((symbol >= '0' ) && (symbol <= '9'))
            {
                System.Console.WriteLine("It's a digit");
            }
            else
            {
                System.Console.WriteLine("it's another sysmbol.");
            }

        }
    }
}
