using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation.*************** ");
            char input;

            do
            {
            int x , y , result;
            char operation;

            System.Console.Write("Input First Number : ");
            x = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Input Second Number : ");
            y = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Input Operation Apply on Numbers : ");
            operation = Convert.ToChar(Console.ReadLine());

            if (operation ==  '+')
            {
                result =  x+y;
                System.Console.WriteLine($"Plus Operation: {x} + {y} = {result}");
            }
            else if (operation ==  '-')
            {
                result =  x-y;
                System.Console.WriteLine($"Minus Operation: {x} - {y} = {result}");
            }
            else if (operation ==  '*' || operation == 'x')
            {
                result =  x*y;
                System.Console.WriteLine($"Multiply Operation: {x} * {y} = {result}");
            }
            else if (operation ==  '/')
            {
                result =  x/y;
                System.Console.WriteLine($"Multiply Operation: {x} / {y} = {result}");
            }
            else
            {
                System.Console.WriteLine("Invalid Input");
            }

            System.Console.WriteLine("*********Do You Want To Apply arthmatic Operation on the numbers Again : **************");           
            System.Console.Write("Write 'Y' to continue or put 'N' to exit:  ");
            
            input = Convert.ToChar(Console.ReadLine());
            if (input == 'y' || input == 'Y')
            {
                continue;
            }
            else if (input == 'n' || input == 'N')
            {
                break;
            }
            else
            {
                break;
            }

            }while(true);
            
        }
    }
}
