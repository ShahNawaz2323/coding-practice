using System;

namespace ConstructPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************Constructor Demonstration***********");
            //Customer customer = new Customer(1,"john");
            Customer customer = new Customer();
            customer.Id = 1;
             
            customer.Name = "john";
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
        }
    }
}
