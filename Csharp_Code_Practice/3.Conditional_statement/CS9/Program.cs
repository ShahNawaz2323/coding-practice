using System;

namespace CS9
{
    class Program
    {
        static void Main(string[] args)
        {
            digits();
        }

        public static void digits()
        {
            do
            {

                Console.WriteLine("\n***************Write a program in C# Sharp to read any digit, display in the word.*************");
                System.Console.Write("\n\n Give digit (0 to 9)to convert it into word....: ");
                int digit = Convert.ToInt32(Console.ReadLine());

                switch (digit)
                {
                    case 1:
                        System.Console.WriteLine("Number is one");
                        break;
                    case 2:
                        System.Console.WriteLine("Number is two");
                        break;
                    case 3:
                        System.Console.WriteLine("Number is three.");
                        break;
                    case 4:
                        System.Console.WriteLine("Number is four");
                        break;
                    case 5:
                        System.Console.WriteLine("Number is five");
                        break;
                    case 6:
                        System.Console.WriteLine("Number is six");
                        break;
                    case 7:
                        System.Console.WriteLine("Number is seven");
                        break;
                    case 8:
                        System.Console.WriteLine("Number is Eight");
                        break;
                    case 9:
                        System.Console.WriteLine("Number is nine");
                        break;
                    default:
                        System.Console.WriteLine("Digit are out of bound of (0-9) digits...");
                        break;
                }
                System.Console.Write("You want to run program again type \"Y\" or \"Any\" to quit: ");
                Char input = Convert.ToChar(Console.ReadLine());
                
                if (input == 'Y' || input == 'y')
                {
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);
        }
    }
}
