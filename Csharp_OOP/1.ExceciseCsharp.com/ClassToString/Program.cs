using System;

namespace ClassToString
{
    class Person{
        // public void toString(string name)
        // {
        //     System.Console.WriteLine("Hello! My name is {0} ",name);
        // }
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
            // person.toString("shah");

            for (int i = 0; i < total; i++)
            {
                person[i] = new Person(){
                    Name = System.Console.ReadLine()
                };
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(person[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
