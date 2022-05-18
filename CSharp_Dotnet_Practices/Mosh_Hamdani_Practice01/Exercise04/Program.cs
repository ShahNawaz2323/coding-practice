using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Random().Next(1,10);

            //System.Console.WriteLine("Secret is " + number);
            for (int i = 0; i < 4; i++)
            {
                System.Console.Write("Guess The Secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    System.Console.WriteLine("You Won");
                    return;
                }
            }
            System.Console.WriteLine("You Lost!,  {0} is secret number. ",number);
            
            
            //Console.WriteLine("Hello World!");
            // int number = 0 ;
            // Random.number = new Random().Next(1,10);
            

            // for (int i = 1; i < 4; i++)
            // {
            //     System.Console.Write("Guess The Number Between 1 to 10");
            //     int input = System.Console.ReadLine();
            //     if (input == number)
            //     {
            //         System.Console.WriteLine("You Win");
            //         break;
            //     }
            //     else
            //     {
            //         continue;
            //     }
            //     System.Console.WriteLine("You Lost Try Again.");
            // }
        }
    }
}
