using System;

namespace SoloPrac4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructors Demonstration: ");
            Person p = new Person("David");
            System.Console.WriteLine(p.getName());

            /*Person c = new Person("45");
            System.Console.WriteLine(c.getAge());
            */
            p.Person(Age);
            System.Console.WriteLine(p.getAge());
        }

    }
    class Person
    {
        private int age;
        private string name;
        public Person(string nm)
        {
            name = nm;
        }
        /*public Person(int nm)
        {
            age = nm;
        }*/
        public string getName()
        {
            return name;
        }
        /*
        public string getAge()
        {
            return age;
        }
        */
    }
}
