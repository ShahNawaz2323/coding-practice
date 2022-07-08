using System;
namespace CS10
{
    public class MonthsDay
    {
        public void Months()
        {
            int MonthNumber = 0;
            System.Console.Write("Please Give Month Number which you want to check ,that month has 30 or 31 days: ");
            MonthNumber = Convert.ToInt32(Console.ReadLine());
            switch (MonthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    System.Console.WriteLine($"This '{MonthNumber} ', have 31 days. ");
                    break;
                case 2:
                    System.Console.WriteLine($"This '{MonthNumber} ', have 29 days. OR 28 if it is a leap year. ");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    System.Console.WriteLine($"This '{MonthNumber} ', have 30 days. ");
                    break;
                default:
                    System.Console.WriteLine("Input outof bound bescase month are 1 to 12");
                    break;
            }
        }
    }

}

