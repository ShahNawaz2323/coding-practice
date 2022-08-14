using System;

namespace Exercise04
{
    class Person
    {
        protected int age;
        public void Greet(string Message)
        {
            System.Console.WriteLine(Message);
        }
        public void SetAge(int Age)
        {
            age = Age ;
            //System.Console.WriteLine("Age is: " + Age );
        }
    }
    class Student : Person
    {
        public void study()
        {
            System.Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            System.Console.WriteLine("My age is: " + age + " years old");
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            System.Console.WriteLine("I'm Explaining");
        }
        public void ShowAge()
        {
            System.Console.WriteLine("My age is: " + age + " years old");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet("Hello");

            Student student = new Student();
            student.Greet("Hello");

            Professor teacher = new Professor();
            teacher.SetAge(25);
            teacher.ShowAge();
            teacher.Greet("Hello");
            teacher.Explain();
        }
    }
}
