using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctr = 0, dd = 0;
            int Id ;
            string Password;
            do
            {
                Console.WriteLine("**********give User Id and Password**********");
                System.Console.Write("User ID : ");
                Id = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("User Pass : ");
                Password = Console.ReadLine();

                if (Id == 123 && Password == "pass")
                {
                    dd = 1;
                    ctr = 3;
                }
                else
                {
                    dd = 0;
                    ctr++;
                }
            } while ((Id != 123 || Password != "pass") && (ctr != 3));
            if (dd == 0)
            {
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            }
            else
         if (dd == 1)
            {
                Console.Write("\nPassword entered successfull!\n\n");
            }
        }


    }
}

