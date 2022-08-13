using System;

namespace Exercise03
{
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "My Name is " + Name;
        }

        ~Person()
        {
            Name = string.Empty;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                System.Console.WriteLine(persons[i].ToString());
            }

            customer cus = new customer("Shah", "Nawaz");

            cus.apendata();
        }
    }
    public class customer
    {
        public string Name { get; set; }

        //Constructor for initializing the fields
        public customer(string fname, string lname)
        {
            Name = fname + " " + lname;
        }
        public void apendata()
        {
            System.Console.WriteLine(Name);
        }
    }
}
