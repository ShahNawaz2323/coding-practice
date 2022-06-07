using System;

namespace CsharpSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Csharp Switch*****************");
            int day = 5;
            int input = 0;
            switch (day)
            {
                case 1:
                System.Console.WriteLine("Monday");
                break;

                case 2:
                System.Console.WriteLine("Tuesday");
                break;

                case 3:
                System.Console.WriteLine("Wednesday");
                break;

                case 4:
                System.Console.WriteLine("Thursday");
                break;

                case 5:
                System.Console.WriteLine("Friday");
                break;

                case 6:
                System.Console.WriteLine("Saturday");
                break;

                case 7:
                System.Console.WriteLine("Sunday");
                break;                
            }
            System.Console.Write("Input the day number: ");
            input = Convert.ToInt32(Console.ReadLine());
            DayDetermine(input);
        }
        public static void DayDetermine(int daySelect)
        {
            switch (daySelect)
            {
                case 1:
                System.Console.WriteLine("Monday");
                break;

                case 2:
                System.Console.WriteLine("Tuesday");
                break;

                case 3:
                System.Console.WriteLine("Wednesday");
                break;

                case 4:
                System.Console.WriteLine("Thursday");
                break;

                case 5:
                System.Console.WriteLine("Friday");
                break;

                case 6:
                System.Console.WriteLine("Saturday");
                break;

                case 7:
                System.Console.WriteLine("Sunday");
                break;

                default : 
                System.Console.WriteLine("Looking Forward for long weekend /No day Selected");
                break;
            }

        }
    }
}
