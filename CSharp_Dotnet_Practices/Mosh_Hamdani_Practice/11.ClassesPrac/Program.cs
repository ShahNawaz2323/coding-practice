using System;

namespace ClassesPrac
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", Name, to);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n__________________Classes______________________");
            
            var person = Person.Parse("Mosh");
            person.Introduce("Shah");
        }
    }
}
