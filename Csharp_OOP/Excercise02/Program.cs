using System;

namespace Excercise02
{
    class customer
    {
        //Member Variables
        public int CustID;
        public string Name;
        public string Address;

        //Constructor for Initializing Fields
        public customer()
        {
            CustID = 1101;
            Name = "Shah";
            Address = "PAK";
        }

        //method for displaying customer records (functionality)
        public void displayData()
        {
            System.Console.WriteLine("Customer : " +CustID );
            System.Console.WriteLine("Name : " + Name);
            System.Console.WriteLine("Address :" + Address);
        }
    }
    // class Person{
    //     public string Name { get; set; }

    //     public Person(string name)
    //     {
    //         Name = name;
    //     }

    //     public override string ToString()
    //     {
    //         return "Hello! My name is " + Name;
    //     }

    //     ~Person()
    //     {
    //         Name = string.Empty;
    //     }
        
    // }
    class Program
    {
        static void Main(string[] args)
        {
            customer custom = new customer();

            custom.displayData();
            // int total = 3;
            // // Console.WriteLine("Hello World!");

            // Person[] persons = new Person[total];

            // for (int i = 0; i < total; i++)
            // {
            //     persons[i] = new Person(Console.ReadLine());
            // }

            // for (int i = 0; i < total; i++)
            // {
            //     System.Console.WriteLine(persons[i].ToString());
            // }
        }
    }
}
