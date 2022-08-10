using System;

namespace Excersie01
{
    class Person{
        public string Name { get; set; }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Person[] person = new Person[total];

            for (int i = 0; i < total; i++)
            {
                System.Console.Write("Your Name is:  ");
                person[i] = new Person()
                {
                    
                    Name = Console.ReadLine()
                };
            }

            for (int i = 0; i < total; i++)
            {
                System.Console.WriteLine(person[i].ToString());
            }
        }
    }
}
