using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {

        //    var sum = 0  ;
        //    while (true)
        //    {
        //        System.Console.WriteLine("Enter a number (or 'ok' to exit): ");
        //        var input = Console.ReadLine();

        //        if (input.ToLower() == "ok")
        //        {
        //            System.Console.WriteLine("Sum of all number is: "+ sum);
        //            break;

        //        }
        //        else
        //        {
        //            sum = sum + Convert.ToInt32(input);
        //        }
               
        //    }
           
           
           
           var number = 0 ;
           
            for (int i = 1; i < 10; i++)
            {
                 Console.Write("Please Provide a number: ");
                 var input = Console.ReadLine();
                
                System.Console.WriteLine("Enter a number or type \"ok\" to exit" );

                //var x = "ok";
                if (input.ToLower() == "ok")
                {
                    System.Console.WriteLine( Convert.ToInt32(number));
                    break;
                }
                else
                {
                    number = number + Convert.ToInt32(input) ;
                }
            }    
                
        }
    }
    
}
